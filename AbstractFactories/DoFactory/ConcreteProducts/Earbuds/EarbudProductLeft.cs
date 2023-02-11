public class EarbudProductLeft : EarbudProduct
{

  private string _brand = "Apple";
  private string _type = "Airpod Pros";
  private string _size = "Medium";
  private string _orientation = "Left";

  public override string brand { get => _brand; }
  public override string type { get => _type; }
  public override string size { get => _size; }
  public override string orientation { get => _orientation; }
}