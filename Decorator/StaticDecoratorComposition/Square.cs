namespace StaticDecoratorComposition;

public class Square(float side) : Shape
{
    private readonly float _side = side;

    public Square() : this(0.0f)
    {
        
    }
    public override string AsString() => $"A square with side {_side}";
}