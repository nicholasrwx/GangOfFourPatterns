namespace DetectingDecoratorCycles;

public class TransparentShape(IShape shape, float transparency) : IShape
{
    private IShape _shape = shape ?? throw new ArgumentNullException(paramName: nameof(shape));
    private float _transparency = transparency;

    public string AsString() => $"{shape.AsString()} has {transparency * 100.0}% transparency";
}