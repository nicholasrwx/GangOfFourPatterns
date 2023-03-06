public class Consumer
{
  public string Name { get; set; }
  public List<string> OccupationalHistory { get; set; }
  public List<string> RecreationalHistory { get; set; }
  public List<string> ContentsConsumed { get; set; }
  public int Health { get; set; }

  public string ConsumerInfo()
  {
    var consumer = $"Consumer: {Name}";
    var occupations = $"Occupational History: {OccupationalHistory.Select(occupation => occupation)}";
    var recreation = $"Recreational History: {RecreationalHistory.Select(recreation => recreation)}";

    return $"{consumer}\n{occupations}\n{recreation}";
  }

  public string HealthInfo()
  {
    var consumption = $"Contents Consumed: {ContentsConsumed.Select(content => content)}";
    var healthImpact = $"Health Impact: +{Health}";
    return $"{consumption}\n{healthImpact}";
  }
}