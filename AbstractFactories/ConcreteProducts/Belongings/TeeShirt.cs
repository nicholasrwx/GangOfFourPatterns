public class TeeShirt : Shirts
{
  public string _brand = "American Fighter";
  public string _color = "Blue";
  public string _material = "Cotton";
  public string _pattern = "MultiThread";
  public string _size = "Medium";
  public string _type = "Tee Shirt";
  public override string brand => _brand;
  public override string color => _color;
  public override string material => _material;
  public override string pattern => _pattern;
  public override string size => _size;
  public override string type => _type;
}