public sealed class AlienBuilder
{
  // Preserve a list of mutating functions
  private readonly List<Func<Alien, Alien>> actions = new List<Func<Alien, Alien>>();

  public AlienBuilder Called(string name) => Do(p => p.Name = name);

  public AlienBuilder Do(Action<Alien> action) => AddAction(action);

  public Alien Build() => actions.Aggregate(new Alien(), (p, f) => f(p));

  // This action parameter gets turned into a func 
  // and added to the actions list of mutating functions
  // This is done to preserve a fluent interface
  // The reason we want to preserve a fluent interface 
  // is because we want to use the aggregate link method 
  //in order to apply all the functions one after another

  //This is a fluent interface because this method returns the containing object, 
  //allowing a user to call the method over and over.
  private AlienBuilder AddAction(Action<Alien> action)
  {
    // this is adding an arrow function
    // the arrow function takes in a parameter
    // passes it to a action method that takes the parameter and modifies it
    // the modified parameter is returned.
    // This arrow function is of type Func<Alien, Alien>
    actions.Add(p => { action(p); return p; });
    return this;
  }
}