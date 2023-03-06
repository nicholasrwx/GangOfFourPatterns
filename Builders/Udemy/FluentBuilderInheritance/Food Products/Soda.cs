public sealed class Soda : IFoodProducts
{
  public List<string> Contents { get; } = new List<string>() { "Sugar", "Caffeine", "Carbonation" };
  public int HealthImpact { get; } = 10;
}