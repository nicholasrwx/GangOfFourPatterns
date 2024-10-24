namespace StaticDecoratorComposition;

public class ShapeDecoratorWithPolicy<T> : TShapeDecorator<T, ThrowOnCyclePolicy>
{
    public ShapeDecoratorWithPolicy(Shape shape) : base(shape)
    {

    }
}