internal class Program
{
  private static void Main(string[] args)
  {
    var planeInfoBuilder = new PlaneInfoBuilder();
    var carInfoBuilder = new CarInfoBuilder();

    var listOfPlanes = planeInfoBuilder
                        .Call("F35", "Fighter Jet")
                        .Call("Boeing 747", "Passenger Plane")
                        .ToString();

    var listOfCars = carInfoBuilder
                        .Call("Ferrari 400", "Sports Car")
                        .Call("Lamborghini Diablo", "Sports Car")
                        .Call("Koenigsegg Gemera", "Sports Car")
                        .ToString();



    Console.WriteLine(listOfPlanes);
    Console.WriteLine(listOfCars);
  }
}