public sealed class Chips : IFoodProducts
{
  public List<string> Contents { get; } = new List<string>() { "Sugar", "Salt", "Carbohydrates", "Fat" };
  public int HealthImpact { get; } = 20;
}