public class Plane
{
  public string Name;
  public string Type;

  public string ToString()
  {
    return $"{nameof(Name)}: {this.name}, {nameof(Type)}: {this.type}";
  }
}