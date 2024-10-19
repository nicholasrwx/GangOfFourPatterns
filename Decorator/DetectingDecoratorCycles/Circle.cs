namespace DetectingDecoratorCycles;

public class Circle(float radius) : IShape
{
    private float _radius = radius;

    public void Resize(float factor)
    {
        _radius *= factor;
    }

    public string AsString() => $"A circle with radius {_radius}";
}