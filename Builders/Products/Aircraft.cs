public class Aircraft
{
  private string _aircraftType;
  private Dictionary<string, string> _parts = new Dictionary<string, string>();
  public Aircraft(string aircraftType)
  {
    this._aircraftType = aircraftType;
  }

  // Indexer
  public string this[string key]
  {
    get { return _parts[key]; }
    set { _parts[key] = value; }
  }
  public void Show()
  {
    Console.WriteLine("\n---------------------------");
    Console.WriteLine(" Vehicle Type: {0}", _aircraftType);
    Console.WriteLine(" Cockpit : {0}", _parts["cockpit"]);
    Console.WriteLine(" Frame : {0}", _parts["frame"]);
    Console.WriteLine(" Engine : {0}", _parts["engine"]);
    Console.WriteLine(" WeaponSystems: {0}", _parts["weaponSystems"]);
    Console.WriteLine(" ElectronicSystems : {0}", _parts["electronicSystems"]);
    Console.WriteLine(" LandingGear : {0}", _parts["landingGear"]);
  }
};