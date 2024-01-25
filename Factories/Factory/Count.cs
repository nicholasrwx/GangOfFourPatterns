public class Count
{
    private double Cups, Bottles;

    public Count(double cups, double bottles)
    {
        this.Cups = cups;
        this.Bottles = bottles;
    }

    public override string ToString()
    {
        return $"{nameof(Cups)}: {Cups}\n{nameof(Bottles)}: {Bottles}";
    }
}