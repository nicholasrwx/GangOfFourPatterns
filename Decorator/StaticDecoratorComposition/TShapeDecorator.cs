namespace StaticDecoratorComposition;
public abstract class TShapeDecorator<TSelf, TCyclePolicy> : ShapeDecorator
    where TCyclePolicy : ShapeDecoratorCyclePolicy, new()
{
    protected readonly TCyclePolicy policy = new();
    protected TShapeDecorator(IShape shape) : base(shape)
    {
        if (policy.TypeAdditionAllowed(typeof(TSelf), _types))
        {
            _types.Add(typeof(TSelf));
        }
    }
}