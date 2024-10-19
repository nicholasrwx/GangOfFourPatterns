namespace DetectingDecoratorCycles;

public class ColoredShape(IShape shape, string color) : IShape
{
    private IShape shape = shape ?? throw new ArgumentNullException(paramName: nameof(shape));
    private string color = color ?? throw new ArgumentNullException(paramName: nameof(color));
    public string AsString() => $"{shape.AsString()} has the color {color}";
};