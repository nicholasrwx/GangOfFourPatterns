public class F35Builder : AircraftBuilder
{
  protected override Aircraft aircraft => new Aircraft("F35");

  public override void Cockpit()
  {
    aircraft["cockpit"] = "Glass Cockpit with a panoramic touch screen";
  }

  public override void ElectronicSystems()
  {
    aircraft["electronicSystems"] = "AESA Radar, BAE Systems, DAS (Distributed Aperture System), CNI Suite";
  }

  public override void Engine()
  {
    aircraft["engine"] = "Pratt & Whitney F135";
  }

  public override void Frame()
  {
    aircraft["frame"] = "three-sided cowl shape";
  }

  public override void WeaponSystems()
  {
    aircraft["weaponSystems"] = "JDAM, Paveway, JSOW, Cluster Munitions, GBU-39, GBU53/B, SPEAR 3, AIM-120 AMRAAM";
  }
}