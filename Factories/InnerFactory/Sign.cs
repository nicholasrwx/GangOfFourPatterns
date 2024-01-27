public class Sign
{
    public string Text;
    public string Type;
    public string Shape;
    public int OrderSize;
    public string OrderWeight;

    private Sign(string text, string type, string shape, int orderSize=10, string orderWeight="25 lbs")
    {
        this.Text = text;
        this.Type = type;
        this.Shape = shape;
        this.OrderSize = orderSize;
        this.OrderWeight = orderWeight;
    }

    // This Factory Method is used to create an order with a default order size / weight
    public static Sign DefaultSignOrder(string text, string type, string shape)
    {
        return new Sign(text, type, shape);
    }
    
    // This static Property is used to return a new premade sign order everytime it is called
    public static Sign PremadeSmileSignOrder => new Sign("Smilie Face Emoji", "Wall Sign", "Circular");

    // This static Field is used to access the same premade sign order every time it is called
    public static Sign PremadeNaanCatSignOrder = new Sign("Naan Cat Emoji", "Wall Sign", "Square");

    // This is an inner factory used to provide additional sign construction abilities
    // It's also a way to construct an object using a factory, when the object has a private constructor
    public static class Factory
    {

        public static Sign CustomSignOrder(string text, string type, string shape, int orderSize, string orderWeight)
        {
            return new Sign(text, type, shape, orderSize, orderWeight);
        }

        public static Sign BlankCustomSignOrder(int orderSize, string orderWeight)
        {
            return new Sign(string.Empty, string.Empty, string.Empty, orderSize, orderWeight);
        }
    }


    public override string ToString()
    {
        return $"Sign Text: {Text}\nSign Type: {Type}\nSign Shape: {Shape}\nOrder Size: {OrderSize}\nOrder Shape: {OrderWeight}\n\n";
    }

}