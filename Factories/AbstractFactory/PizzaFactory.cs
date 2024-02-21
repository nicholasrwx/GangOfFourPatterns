internal class PizzaFactory : IMicrowavedFoodFactory
{
    public IMicrowavedFood Prepare(int amount)
    {
        Console.WriteLine($"1) Take the pizza out of the box\n2) Put {amount} slices on a plate\n3) Place in the microwave for {amount*30} seconds\n4) Season and enjoy!");
        return new Pizza();
    }
}