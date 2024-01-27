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

    public override string ToString()
    {
        return $"Sign Text: {Text}\nSign Type: {Type}\nSign Shape: {Shape}\nOrder Size: {OrderSize}\nOrder Shape: {OrderWeight}\n\n";
    }

    public static Sign DefaultSignOrder(string text, string type, string shape)
    {
        return new Sign(text, type, shape);
    }


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
}