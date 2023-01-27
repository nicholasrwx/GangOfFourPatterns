public class F22Builder : AircraftBuilder
{

  public Aircraft _aircraft;

  public F22Builder()
  {
    this._aircraft = new Aircraft("F22 Raptor");
  }

  public override void Cockpit()
  {
    _aircraft["cockpit"] = "Glass cockpit with heads up display";
  }

  public override void ElectronicSystems()
  {
    _aircraft["electronicSystems"] = "Radar, Missile Launch Detector, Electronic Warfar System, Radar Warning Receiver, Integrated CNI Avionics";
  }

  public override void Engine()
  {
    _aircraft["engine"] = "Pratt & Whitney F119";
  }

  public override void Frame()
  {
    _aircraft["frame"] = "Diamond Shape";
  }

  public override void WeaponSystems()
  {
    _aircraft["weaponSystems"] = "M61A2 Vulcan rotary cannon, AIM-120C/D AMRAAM, AIM-9 Sidewinder, JDAM, GBU-39";
  }
}