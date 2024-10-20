namespace StaticDecoratorComposition;

public class ColoredShape 
    // : TShapeDecorator<ColoredShape, ThrowOnCyclePolicy>
// : TShapeDecorator<ColoredShape, CyclesAllowedPolicy>
: TShapeDecorator<ColoredShape, AbsorbCyclePolicy>
// : ShapeDecoratorWithPolicy<ColoredShape>
{
    private readonly string _color;

    public ColoredShape(IShape shape, string color) : base(shape)
    {
        // this._shape = shape;
        this._color = color;

    }

    // Works With AbsorbCyclePolicy
    // Had to turn AsString to virtual member and override here to make it work

    public override string AsString()
    {
        var sb = new StringBuilder($"{_shape.AsString()}");
        // _types initialized
        // _types[0] -> current
        // _types[1...] -> what it wraps
        if (policy.ApplicationAllowed(_types[0], _types.Skip(1).ToList()))
            sb.Append($" has the color {_color}");
        
        return sb.ToString();
    }

    // Works with CyclesAllowedPolicy and ThrowOnCyclePolicy
    // public string AsString() => $"{_shape.AsString()} has the color {_color}";
}