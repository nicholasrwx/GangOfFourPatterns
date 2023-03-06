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
    var recreations = $"Recreational History: ";

    occupations += Consumer.ToString(_occupationalHistory);
    recreations += Consumer.ToString(_recreationalHistory);

    return $"{consumer}\n{occupations}\n{recreations}";
  }

  public string HealthInfo()
  {
    var consumptions = $"Contents Consumed: ";
    var healthImpact = $"Health Impact: +{_health}";

    consumptions += Consumer.ToString(_contentsConsumed);

    return $"{consumptions}\n{healthImpact}";
  }

  static string ToString(List<string> titles)
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

  public string _name;
  public List<string> _occupationalHistory;
  public List<string> _recreationalHistory;
  public List<string> _contentsConsumed;
  public int _health;
}