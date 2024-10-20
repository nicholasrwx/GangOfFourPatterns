namespace StaticDecoratorComposition;

public class ShapeDecorator : Shape
{
    protected internal readonly List<Type> _types = [];
    protected internal Shape _shape;

    public ShapeDecorator(Shape shape)
    {
        this._shape = shape;
        if (_shape is ShapeDecorator sd)
        {
            _types.AddRange(sd._types);
        }
    }

    public override string AsString()
    {
        throw new NotImplementedException();
    }
}