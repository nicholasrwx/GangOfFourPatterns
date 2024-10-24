namespace StaticDecoratorComposition;

public class TransparentShape<T> : Shape where T : Shape, new()
// : TShapeDecorator<ColoredShape, ThrowOnCyclePolicy>
// : TShapeDecorator<ColoredShape, CyclesAllowedPolicy>
// : TShapeDecorator<ColoredShape, AbsorbCyclePolicy>
// : ShapeDecoratorWithPolicy<ColoredShape>
{
    private readonly float _transparency;
    private readonly T _shape = new T();

    public TransparentShape() : this(0)
    {

    }

    public TransparentShape(float transparency)
    {
        this._transparency = transparency;

    }

    public override string AsString() => $"{_shape.AsString()} has {_transparency * 100.0f}% transparency.";
}