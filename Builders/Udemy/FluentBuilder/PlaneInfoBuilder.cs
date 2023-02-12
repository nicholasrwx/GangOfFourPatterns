public class PlaneInfoBuilder
{
  protected Planes planes = new Planes();

  public PlaneInfoBuilder Call(string name, string type)
  {
    planes.Names.Add(name);
    planes.Types.Add(type);
    return this;
  }

  public override string ToString()
  {
    return planes.BuildString();
  }
}