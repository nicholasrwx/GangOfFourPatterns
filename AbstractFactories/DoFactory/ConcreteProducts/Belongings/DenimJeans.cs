public class DenimJeans : Pants
{
  public string _brand = "True Religion";
  public string _color = "White Ash";
  public string _material = "Denim";
  public string _pattern = "Acid Wash";
  public string _size = "34 x 36";
  public string _type = "Rock & Roll Jeans";
  public override string brand => _brand;
  public override string color => _color;
  public override string material => _material;
  public override string pattern => _pattern;
  public override string size => _size;
  public override string type => _type;
}