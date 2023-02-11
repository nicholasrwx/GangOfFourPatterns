public class PlaneInfoBuilder
{
  protected Plane plane = new Plane();

  public PlaneInfoBuilder called(string name, string type)
  {
    plane.Name = name;
    plane.Type = type;
    return this;
  }
}