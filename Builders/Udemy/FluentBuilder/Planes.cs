public class Planes
{
  public List<string> Names = new List<string>();
  public List<string> Types = new List<string>();

  public string PlaneList;

  public string BuildString()
  {
    foreach (var name in Names)
    {
      PlaneList += $"{nameof(name)}: {name}";
      foreach (var type in Types)
      {
        PlaneList += $", {nameof(type)}: {type}\n";
        break;
      }

    }

    return PlaneList;
  }
}