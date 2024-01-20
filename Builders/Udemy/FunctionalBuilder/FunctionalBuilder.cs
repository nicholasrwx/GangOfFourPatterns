public abstract class FunctionalBuilder<TSubject, TSelf> where TSelf : FunctionalBuilder<TSubject, TSelf> where TSubject: new()
{
    // Preserve a list of mutating functions
    private readonly List<Func<Alien, Alien>> actions = new List<Func<Alien, Alien>>();
    public TSelf Do(Action<Alien> action) => AddAction(action);
    public Alien Build() => actions.Aggregate(new Alien(), (p, f) => f(p));
    private TSelf AddAction(Action<Alien> action)
    {
        actions.Add(p => { action(p); return p; });
        return (TSelf) this;
    }
}

public sealed class FluentAlienBuilder : FunctionalBulider<Alien, AlienBuilder>
{
    public FluentAlienBuilder Called(string name) => Do(p => p.Name = name);
}