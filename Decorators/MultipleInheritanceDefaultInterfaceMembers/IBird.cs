namespace MultipleInheritanceDefaultInterfaceMembers;

public interface IBird : ICreature
{
    void Fly()
    {
        if (Age >= 10)
            WriteLine("I am flying.");
    }
}