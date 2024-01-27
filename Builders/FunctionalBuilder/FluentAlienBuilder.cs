// TSubject will be our instance in the Buid() method
// Build runs the Aggregate function on the list of Func<T, T>
// The Funcs are setup with the Do Method which take the Actions<T>
//Example:

//    Action:                                    p => p.Name = name
//    Is used as the action in Func:             p => { action(p); return p; }
//    Action:                                    p => p.Position = position
//    Is used as the action in another Func:     p => { action(p); return p; }
//    Both Funcs get stored in                   List<Func<TSubject, TSubject>> actions
//    Both Funcs get executed on TSubject:       actions.Aggregate(new TSubject(), (p, f) => f(p))

//    TSubject is the seed value for the aggregate method ( will set the initial accumulator value )
//    p is the next accumulated value to be used in the aggregate method
//    f is the next source value from which the aggregate method is being called on
//    ( in this case its the list of functions called 'actions' )

public abstract class GenericFluentBuilder<TSubject, TSelf>
    where TSelf: GenericFluentBuilder<TSubject, TSelf>
    where TSubject: new()
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
