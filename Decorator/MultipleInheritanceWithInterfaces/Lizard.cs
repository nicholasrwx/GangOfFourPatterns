namespace MultipleInheritanceWithInterfaces;

public class Lizard : ILizard
{
    public int Weight { get; set; }
    public void Crawl()
    {
        WriteLine($"Crawling in the dirt with weight {Weight}");
    }
}