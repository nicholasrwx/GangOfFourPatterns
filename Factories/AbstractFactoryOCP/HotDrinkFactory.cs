internal class HotDrinkFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"1) Grab a mug\n2) Place {amount} scoops of hot chocolate in the cup\n3) Place in microwave for {amount * 10} seconds\n4) Stir and enjoy!");
        return new HotDrink();
    }
}