internal class ChowMeinFactory : IMicrowavedFoodFactory
{
    public IMicrowavedFood Prepare(int amount)
    {
        Console.WriteLine($"1) Open the chow mein tin\n2) Place {amount} scoops on a plate\n3) Place in microwave for {amount * 20} seconds\n4) Stir and enjoy!");
        return new ChowMein();
    }
}