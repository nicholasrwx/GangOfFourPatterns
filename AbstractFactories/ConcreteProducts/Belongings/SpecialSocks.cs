public class SpecialSocks : Socks
{
  public string _brand = "Polo";
  public string _color = "Black";
  public string _material = "Nylon and Cotton";
  public string _pattern = "Polo Player on Repeat";
  public string _size = "6-11";
  public string _type = "Long Socks";
  public override string brand => _brand;
  public override string color => _color;
  public override string material => _material;
  public override string pattern => _pattern;
  public override string size => _size;
  public override string type => _type;
}