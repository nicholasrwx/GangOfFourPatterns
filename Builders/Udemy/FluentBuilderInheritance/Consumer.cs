public class Consumer
{

  public Consumer()
  {
    this._name = "";
    this._occupationalHistory = new List<string>();
    this._recreationalHistory = new List<string>();
    this._contentsConsumed = new List<string>();
    this._health = 0;
  }

  public string ConsumerInfo()
  {
    var consumer = $"Consumer: {_name}";
    var occupations = "Occupational History: ";
    var recreations = "Recreational History: ";

    occupations += Consumer.StringBuilder(_occupationalHistory);
    recreations += Consumer.StringBuilder(_recreationalHistory);

    return $"{consumer}\n{occupations}\n{recreations}";
  }

  public string HealthInfo()
  {
    var consumptions = "Contents Consumed: ";
    var healthImpact = $"Health Impact: +{_health}";

    consumptions += Consumer.StringBuilder(_contentsConsumed);

    return $"{consumptions}\n{healthImpact}";
  }

  static string StringBuilder(List<string> titles)
  {
    var result = "";

    foreach (var title in titles)
    {
      if (titles.IndexOf(title) == titles.Count - 1)
        result += $"{title}.";
      else
        result += $"{title}, ";
    }

    return result;
  }

  public class Builder : ConsumerHealthBuilder<Builder>
  {

  }

  // This is done statically because you cannot call an instance method from a static method
  // So when you try and call this from the static main method, it won't error out this way
  public static Builder New => new Builder();

  public string _name;
  public List<string> _occupationalHistory;
  public List<string> _recreationalHistory;
  public List<string> _contentsConsumed;
  public int _health;
}