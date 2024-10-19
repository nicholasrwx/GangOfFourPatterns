namespace DetectingDecoratorCycles;

public class ShapeDecoratorWithPolicy<T> : TShapeDecorator<T, ThrowOnCyclePolicy>
{
    public ShapeDecoratorWithPolicy(IShape shape) : base(shape)
    {

    }
}