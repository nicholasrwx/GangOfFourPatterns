namespace StaticDecoratorComposition;

public class TransparentShape<T> : Shape where T : Shape, new()
// : TShapeDecorator<ColoredShape, ThrowOnCyclePolicy>
// : TShapeDecorator<ColoredShape, CyclesAllowedPolicy>
// : TShapeDecorator<ColoredShape, AbsorbCyclePolicy>
// : ShapeDecoratorWithPolicy<ColoredShape>
{
    private readonly float _transparency;
    private readonly T _shape = new T();

    public TransparentShape() : this("black")
    {

    }

    public TransparentShape(string color)
    {
        this._color = color ?? throw new ArgumentNullException(paramName: nameof(color));

    }

    public override string AsString() => $"{_shape.AsString()} has the color {_color}";
}