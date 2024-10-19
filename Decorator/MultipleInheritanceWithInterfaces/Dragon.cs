namespace MultipleInheritanceWithInterfaces;
public class Dragon : IBird, ILizard
{
    private Bird bird = new Bird();
    private Lizard lizard = new Lizard();
    
    public void Fly()
    {
        bird.Fly();
    }

    public void Crawl()
    {
        lizard.Crawl();
    }
}