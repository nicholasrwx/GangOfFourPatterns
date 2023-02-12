public class Plane
{
  public string Name;
  public string Type;

  public override string ToString()
  {
    return $"{nameof(Name)}: {Name}, {nameof(Type)}: {Type}";
  }
}