# MotoGP-18-UDP-Telemetry
MotoGP 18 UDP Telemetry structure

This structure was originally intended for SimHub usage (https://www.racedepartment.com/downloads/simhub-diy-sim-racing-dash.10252/)

Milestone refused to give descriptions of the telemetry, so I had to reverse engeneer it using the few informations available (basically using the non ordered property list given by the only 3rd party tool having access to the data : SRT). 

I hope that publishing it would make Milestone more open for their next games and help developpers.  

## A few additionnal informations

- UDP packets are broadcasted to UDP port 7100
- Telemetry is only sent offline
- A very few holes are remaining in the structure, but 80% of the data are parsed

## Mapping status :

Gray are mapped, white not mapped yet

![](https://i.imgur.com/qCBCbZ5.png)

Have fun !
