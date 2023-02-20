public class CarInfoBuilder
{

  protected Cars cars = new Cars();

  public CarInfoBuilder Call(string name, string type)
  {
    cars.Types.Add(name, type);
    return this;
  }

  public override string ToString()
  {
    return cars.BuildString();
  }
}