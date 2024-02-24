public class HotDrinkMachine
{
    // Adhering to the Open Closed Principal ( OCP ) instead of a nested ENUM
    // We are implementing this using Reflection

    // This hot drink machine, gets all types in the hot drink assembly.
    // We filter all the types out for the ones with the IHotDrinkFactory type
    // When we find them they are added to the factories list
    // ( Or something along these lines )

    private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();

    public HotDrinkMachine()
    {
        foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
            {
                factories.Add(
                    Tuple.Create(t.Name.Replace("Factory", string.Empty),
                    (IHotDrinkFactory)Activator.CreateInstance(t)));
            }
        }
    }

    public IHotDrink MakeDrink()
    {
        Console.WriteLine("Available Drinks");
        for (var index = 0; index < factories.Count; index++)
        {
            var tuple = factories[index];
            Console.WriteLine($"{index}: {tuple.Item1}");
        }

        while (true)
        {
            string s;
            // Grabs the string value from the command line and converts it to an integer
            if (
                (s = Console.ReadLine()) != null // waits for input from user
                 && int.TryParse(s, out int i)
                 && i >= 0
                 && i < factories.Count)
            {
                Console.WriteLine("Specify amount: "); // waits for input from user
                s = Console.ReadLine();
                if (s != null
                    && int.TryParse(s, out int amount)
                    && amount > 0)
                {
                    return factories[i].Item2.Prepare(amount); // takes the input and uses it as the key to the factories list
                }

            }
            Console.WriteLine("Incorrect Input, Try Again!");
        }
    }
}