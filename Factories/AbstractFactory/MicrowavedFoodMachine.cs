public class MicrowavedFoodMachine
{
    public enum AvailableFood
    {
        Pizza,
        ChowMein
    }

    private Dictionary<AvailableFood, IMicrowavedFoodFactory> factories = new Dictionary<AvailableFood, IMicrowavedFoodFactory>();

    public MicrowavedFoodMachine()
    {
        foreach (AvailableFood food in Enum.GetValues(typeof(AvailableFood)))
        {
            var factory = (IMicrowavedFoodFactory) Activator.CreateInstance(Type.GetType(food + "Factory"));
            factories.Add(food, factory);
        }
    }

    public IMicrowavedFood MakeFood(AvailableFood food, int amount)
    {
        return factories[food].Prepare(amount);
    }
}