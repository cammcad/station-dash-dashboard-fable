module App

open ADab
open ADashboard
open Browser.Dom

let stationsUI = document.getElementById("stations")
let addStationToPage (station: string) =
  let item = document.createElement("li")
  let textNode = document.createTextNode(station)
  item.appendChild(textNode) |> ignore
  stationsUI.appendChild(item) |> ignore


let stations = exec(data) // run it!
for station in stations do
  addStationToPage(station)
