namespace StaticDecoratorComposition;

public class AbsorbCyclePolicy : ShapeDecoratorCyclePolicy
{
    // Allows Construction No Matter What
    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
        return true;
    }

    // Allows Application only if all the Types do not contain the Current Type
    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
        return !allTypes.Contains(type);
    }
}