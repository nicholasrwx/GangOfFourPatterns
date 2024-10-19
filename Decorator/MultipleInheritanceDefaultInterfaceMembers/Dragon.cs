namespace MultipleInheritanceDefaultInterfaceMembers;

// Adding Additional Storage ( Fields ) - You can use Inheritance provided you don't need to inherit from multiple base classes, or you can use a wrapper class like SmartDragon(Dragon).
// Adding Behavior - You can use extension methods, or you can use the C#8 Default Interface Methods.

// Inheriting from Organism prevents inheritance from additional classes that could provide additional behavior
public class Dragon : Organism, ICreature, IBird, ILizard
{
    public int Age { get; set; }
}