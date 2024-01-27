public sealed class Steak : IFoodProducts
{
  public List<string> Contents { get; } = new List<string>() { "Proteine", "Vitamin B", "Fat" };
  public int HealthImpact { get; } = 60;
}