public abstract class AircraftBuilder
{
  protected abstract Aircraft aircraft { get; }

  public abstract void Cockpit();
  public abstract void ElectronicSystems();
  public abstract void Engine();
  public abstract void Frame();
  public abstract void WeaponSystems();
}