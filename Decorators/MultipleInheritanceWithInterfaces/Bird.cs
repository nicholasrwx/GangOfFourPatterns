namespace MultipleInheritanceWithInterfaces;

public class Bird : IBird
{
    public int Weight { get; set; }
    public void Fly()
    {
        WriteLine($"Soaring in the sky with weight {Weight}");
    }
}