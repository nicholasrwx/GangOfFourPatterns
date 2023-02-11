public class Boxers : Underwear
{
  public string _brand = "Saxx";
  public string _color = "Black";
  public string _material = "Nylon";
  public string _pattern = "Pink Dolphins";
  public string _size = "Medium";
  public string _type = "Sports Underwear";
  public override string brand => _brand;
  public override string color => _color;
  public override string material => _material;
  public override string pattern => _pattern;
  public override string size => _size;
  public override string type => _type;
}