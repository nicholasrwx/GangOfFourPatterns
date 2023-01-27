public class F35Builder : AircraftBuilder
{
  public Aircraft _aircraft;

  public F35Builder()
  {
    this._aircraft = new Aircraft("F35");
  }

  public override void Cockpit()
  {
    _aircraft["cockpit"] = "Glass Cockpit with a panoramic touch screen";
  }

  public override void ElectronicSystems()
  {
    _aircraft["electronicSystems"] = "AESA Radar, BAE Systems, DAS (Distributed Aperture System), CNI Suite";
  }

  public override void Engine()
  {
    _aircraft["engine"] = "Pratt & Whitney F135";
  }

  public override void Frame()
  {
    _aircraft["frame"] = "three-sided cowl shape";
  }

  public override void WeaponSystems()
  {
    _aircraft["weaponSystems"] = "JDAM, Paveway, JSOW, Cluster Munitions, GBU-39, GBU53/B, SPEAR 3, AIM-120 AMRAAM";
  }
}