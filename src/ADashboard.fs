module ADashboard

  open System
  open ADab
  open ACoreDefs
  open Fable.Core

  type IConvertTZ =
    abstract convertTZ : string -> DateTime -> DateTime
  
  [<Import("*","./js/date.js")>]
  let datelib: IConvertTZ = jsNative
  let convertHawaiiTZ = datelib.convertTZ("Pacific/Honolulu")
  

  type HawaiiTime = {Day: int; Hour: int; Minute: int; Am_Pm: string; }

  let getTime (date: DateTime) = 
    let hour = date.Hour
    let toTwelveHourClock hour = if hour >= 12 then hour - 12 elif hour = 0 then 12 else hour
    { Day = date.Day; 
      Hour = toTwelveHourClock(hour);
      Minute = date.Minute;
      Am_Pm = if hour >= 12 then "pm" else "am" }
  
  let hawaiiTime = getTime << convertHawaiiTZ
  let propDay r = r.Day
  let propDays r = r.Days
  let propOpen r = r.Open
  let propClose r = r.Close
  let getDay = propDay << hawaiiTime

  (* Transfer Station Domain *)
  let convertDayToInt (day: string) =
    match day.ToLower() with
    | "monday" -> 1
    | "tuesday" -> 2
    | "wednesday" -> 3
    | "thursday" -> 4
    | "friday" -> 5
    | "saturday" -> 6
    | _ -> 0

  let facilityClosed facility = Nothing($"{facility.Name}: closed")
  let openNow facility = Just($"{facility.Name}: open now, closes at ${facility.Close} pm")
  
  let getDays = Array.map(convertDayToInt) << fun (x: string) -> x.Split('/')
  let byDay =
    let d = getDay(DateTime.Now)
    Array.exists(fun i -> i = d)

  let isToday = (byDay << getDays) << propDays

  let maybeOpenByDay facility =
    if isToday(facility) then Just(facility) else Nothing(facility)

  let hourToInt = Int32.Parse << (fun (x: string) -> x.Split(':').[0])
  let getOpenHour = hourToInt << propOpen
  let getClosedHour = hourToInt << propClose
  let isAM (x: HawaiiTime) = x.Am_Pm = "am"

  let maybeOpenByHour (time, facility) = 
    if isAM(time) then 
      (if time.Hour < getOpenHour(facility) then facilityClosed(facility) else openNow(facility))
    else
      (if time.Hour >= getClosedHour(facility) then facilityClosed(facility) else openNow(facility))
  
  let isOpen facility =
    let res = maybeOpenByDay(facility)
    match res with
    | Nothing x -> facilityClosed(x)
    | Just x -> maybeOpenByHour(hawaiiTime(DateTime.Now), x)

  type 'a TransferStation = 
    | TransferStation of 'a 
    
      member self.Map f = 
        match self with
        | TransferStation x -> TransferStation(f x)
      
      member self.Fold f =
        match self with
        | TransferStation x -> f x
      
      override self.ToString() =
        match self with
        | TransferStation x -> $"TransferStation({x})"
  
  let getFacilityHours =  (fun (x: TransferStation<Facility>) -> x.Map(isOpen)) << TransferStation
  let unWrapTransferStations (tfs: TransferStation<Maybe<string>>) = tfs.Fold(id).Fold(id,id)
  let getTransferStationHours = unWrapTransferStations << getFacilityHours
  let exec = Array.map(getTransferStationHours)