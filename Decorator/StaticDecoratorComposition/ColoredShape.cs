namespace StaticDecoratorComposition;

// We are doing this because we can't inherit from a parameter like this: ColoredShape<T> : T
// The above is CRTP ( Curiously Recurring Template Pattern ) which does not exist in C#
// We extend Shape with ColoredShape, constrain T to Type Shape as-well as a Parameterless Constructor 
public class ColoredShape<T> : Shape where T : Shape, new()
    // : TShapeDecorator<ColoredShape, ThrowOnCyclePolicy>
    // : TShapeDecorator<ColoredShape, CyclesAllowedPolicy>
    // : TShapeDecorator<ColoredShape, AbsorbCyclePolicy>
    // : ShapeDecoratorWithPolicy<ColoredShape>
{
    private readonly string _color;
    private readonly T _shape = new T();

    // Default constructor is required because of the new() constraint even though it's a ColoredShape
    // this() is a shorthand/implied way of setting the color property to a default color
    public ColoredShape() : this("black") { }

    public ColoredShape(string color)
    {
        this._color = color ?? throw new ArgumentNullException(paramName: nameof(color));

    }

    public override string AsString() => $"{_shape.AsString()} has the color {_color}";
}