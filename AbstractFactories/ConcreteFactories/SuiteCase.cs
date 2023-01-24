using System.Collections.Generic;

public class SuiteCase : CaseFactory
{
  private Boxers _underwear;
  private DenimJeans _jeans;
  private LeatherJacket _jacket;
  private SpecialSocks _socks;
  private TeeShirt _shirt;
  private PlushElephant _teddy;

  public SuiteCase()
  {
    _underwear = new Boxers();
    _jeans = new DenimJeans();
    _jacket = new LeatherJacket();
    _socks = new SpecialSocks();
    _shirt = new TeeShirt();
    _teddy = new PlushElephant();
  }
  public override void CaseItems()
  {
    var packedSuitecase = SuiteCaseNome();
    Console.WriteLine("The Suitecase Nome packed:");
    foreach (var belonging in packedSuitecase)
    {
      Console.WriteLine(belonging.type);
    }
  }

  public List<IBelongings> SuiteCaseNome()
  {
    return PackTheSuiteCase(_underwear, _jeans, _jacket, _socks, _shirt, _teddy);
  }

  public List<IBelongings> PackTheSuiteCase(params IBelongings[] suitcaseItems)
  {
    List<IBelongings> items = new List<IBelongings>();

    foreach (var item in suitcaseItems)
    {
      items.Add(item);
      if (item.type.Equals(_teddy.type))
      {
        StuffedAnimal animal = (StuffedAnimal)item;
        Console.WriteLine($"the elphant plushy rudely remarked, \"{animal.phrase}\",\nto the suitecase nome as he packed him away for a plane ride.\n");
      }
    }
    return items;
  }
}