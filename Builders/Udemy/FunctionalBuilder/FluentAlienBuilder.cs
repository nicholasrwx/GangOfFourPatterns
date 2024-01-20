public abstract class GenericFluentBuilder<TSubject, TSelf> where TSelf : GenericFluentBuilder<TSubject, TSelf> where TSubject: new()
{
    // Preserve a list of mutating functions
    private readonly List<Func<TSubject, TSubject>> actions = new List<Func<TSubject, TSubject>>();
    public TSelf Do(Action<TSubject> action) => AddAction(action);
    public TSubject Build() => actions.Aggregate(new TSubject(), (p, f) => f(p));
    private TSelf AddAction(Action<TSubject> action)
    {
        actions.Add(p => { action(p); return p; });
        return (TSelf) this;
    }
}

public sealed class FluentAlienBuilder : GenericFluentBuilder<Alien, FluentAlienBuilder>
{
    public FluentAlienBuilder Called(string name) => Do(p => p.Name = name);
}