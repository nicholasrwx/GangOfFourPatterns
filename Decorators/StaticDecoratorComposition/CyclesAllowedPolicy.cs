namespace StaticDecoratorComposition;

// Allows Unlimited Cycles of Any Type For Any Application
public class CyclesAllowedPolicy : ShapeDecoratorCyclePolicy
{
    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
        return true;
    }

    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
        return true;
    }
}