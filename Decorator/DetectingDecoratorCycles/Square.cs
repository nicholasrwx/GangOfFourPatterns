namespace DetectingDecoratorCycles;

public class Square(float side) : IShape
{
    private readonly float _side = side;

    public string AsString() => $"A square with side {_side}";
}