public class Cars
{

  public string _carList;
  public Dictionary<string, string> Types = new Dictionary<string, string>();

  public string BuildString()
  {
    foreach (var type in Types)
    {
      _carList += $"name: {type.Key}, type: {type.Value}\n";
    }

    return _carList;
  }
}
