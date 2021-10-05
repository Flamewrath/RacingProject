# RacingProject
Represents a race via strings
# Description
Simulates a race between cars, trucks and bikes.
Race settings must be set in a .json file in working directory (config.json).
# Race Settings
"RaceDistance" - length of a lap in meters;

"RefreshTime" - represents how often information about racing will be refresh.
# Vehicle settings
"Speed" - Speed of vehicle in km/h;

"PunctureProb" - tire puncture probability of a vehicle in % (0-100);

"PunctureTime" - time in seconds, which require to repaire a vehicle.
### Car settings
"PeopleCount" - total people count, which are in a car.
### Truck settings
"CargoWeight" - total weight in a truck in kg.
### Bike settings
"Carriage" - does a bike have a carriage in bool (true/false).
# Additional information
Program written on C# on Windows 10 (.NET Framework 4.8).

Platform: x86.

Works in multi-threading.

MVC Architecture Pattern.
