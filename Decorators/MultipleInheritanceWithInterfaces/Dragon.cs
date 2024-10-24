namespace MultipleInheritanceWithInterfaces;

// Using the Decorator Pattern with Interfaces kind of works,
// however you run into issues with implementing some times of members.
// It is not convenient to work with.
public class Dragon : IBird, ILizard
{
    private Bird bird = new Bird();
    private Lizard lizard = new Lizard();
    private int weight;

    public void Fly()
    {
        bird.Fly();
    }

    public void Crawl()
    {
        lizard.Crawl();
    }

    // Weight has to be set this way. Other-wise if you implement missing members it won't allow you to do it.
    // It kind of becomes ambiguous and automatically makes the bird.weight and lizard.weight properties inaccessible.
    public int Weight
    {
        get
        {
            return weight;
        }
        set
        {
            weight = value;
            bird.Weight = value;
            lizard.Weight = value;
        }
    }
}