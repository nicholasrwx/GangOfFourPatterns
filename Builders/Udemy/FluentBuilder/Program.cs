var planeInfoBuilder = new PlaneInfoBuilder();
var listOfPlanes = planeInfoBuilder
                    .Call("F35", "Fighter Jet")
                    .Call("Boeing 747", "Passenger Plane")
                    .ToString();

Console.WriteLine(listOfPlanes);