public class Shop
{
  public void Construct(AircraftBuilder builder)
  {
    //The beauty about this, is that it gives me a-lot of control over different features that I wish to implement.
    //The product instantiated within the builder
    builder.Cockpit();
    builder.ElectronicSystems();
    builder.Engine();
    builder.Frame();
    builder.WeaponSystems();
  }
}