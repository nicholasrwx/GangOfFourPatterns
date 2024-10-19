namespace DetectingDecoratorCycles;

public class ColoredShape
    : TShapeDecorator<ColoredShape, ThrowOnCyclePolicy>
    // : ShapeDecoratorWithPolicy<ColoredShape>
{
    private readonly string _color;
    public ColoredShape(IShape shape, string color) : base(shape)
    {
        // this._shape = shape;
        this._color = color;

    }

public string AsString() => $"{_shape.AsString()} has the color {_color}";
};