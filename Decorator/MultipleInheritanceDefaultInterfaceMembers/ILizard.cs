namespace MultipleInheritanceDefaultInterfaceMembers;

public interface ILizard : ICreature
{
    void Crawl()
    {
        if (Age < 10)
            WriteLine("I am crawling.");
    }
}