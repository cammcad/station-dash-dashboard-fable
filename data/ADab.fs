module ADab
  
  type Facility = 
    { Name: string
      Open: string
      Close: string
      Days: string
      Address: string }
  
  let data =
    [|
        {
          Name = "Glenwood"
          Open = "6:00"
          Close = "6:00"
          Days = "Sunday/Tuesday/Friday"
          Address = "18-2463 Ala Mahina'ai"
        };
        {
          Name = "Hāwī (Ka‘auhuhu)"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday"
          Address = "55-3595 Kaʻauhuhu Road"
        };
        {
          Name = "Hilo"
          Open = "6:30"
          Close = "5:00"
          Days = "Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday"
          Address = "1471 Ho‘olaulima Road"
        };
        {
          Name = "Honoka‘a"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday"
          Address = "45-624 Plumeria Street"
        };
        {
          Name = "Honomū"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Thursday/Saturday"
          Address = "28-1844 Old Māmalahoa Highway"
        };
        {
          Name = "Kailua-Kona (Kealakehe)"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday"
          Address = "74-598 Hale Māka‘i Place"
        };
        {
          Name = "Kalapana"
          Open = "8:00"
          Close = "4:00"
          Days = "Saturday/"
          Address = "74-598 Hale Māka‘i Place"
        };
        {
          Name = "Kea‘au"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday"
          Address = "16-921 Kea‘au-Pāhoa Road"
        };
        {
          Name = "Keauhou"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday"
          Address = "79-7098 Māmalahoa Highway"
        };
        {
          Name = "Ke‘ei"
          Open = "6:00"
          Close = "6:00"
          Days = "Tuesday/Friday/Sunday"
          Address = "83-6180 Pu‘uhonua Road"
        };
        {
          Name = "Laupāhoehoe"
          Open = "6:00"
          Close = "6:00"
          Days = "Tuesday/Friday/Sunday"
          Address = "35-2061 Old Māmalahoa Highway"
        };
        {
          Name = "Miloli‘i"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday"
          Address = "89-1217 Miloli‘i Road"
        };
        {
          Name = "Ocean View"
          Open = "8:00"
          Close = "4:00"
          Days = "Monday/Thursday/Saturday"
          Address = "92-9017 Māmalahoa Highway"
        };
        {
          Name = "Pa‘auilo"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Thursday/Saturday"
          Address = "43-1615 Hauola Road"
        };
        {
          Name = "Pāhala"
          Open = "6:00"
          Close = "6:00"
          Days = "Sunday/Tuesday/Friday"
          Address = "96-1250 Old Māmalahoa Highway"
        };
        {
          Name = "Pāhoa"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday"
          Address = "15-1870 Cemetery Road"
        };
        {
          Name = "Pāpa‘ikou"
          Open = "6:00"
          Close = "6:00"
          Days = "Sunday/Tuesday/Friday"
          Address = "27-215 Old Māmalahoa Highway"
        };
        {
          Name = "Puakō"
          Open = "6:00"
          Close = "6:00"
          Days = "Sunday/Tuesday/Friday"
          Address = "66-1471 Puakō Beach Drive"
        };
        {
          Name = "Volcano"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Thursday/Saturday"
          Address = "19-3438 Volcano Road"
        };
        {
          Name = "Waiea"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Thursday/Saturday"
          Address = "86-3895 Hawai‘i Belt Road"
        };
        {
          Name = "Waimea"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday"
          Address = "66-1597 Kawaihae Road"
        };
        {
          Name = "Wai‘ōhinu"
          Open = "6:00"
          Close = "6:00"
          Days = "Monday/Thursday/Saturday"
          Address = "95-6155 Kaulia Road"
        }
    |]