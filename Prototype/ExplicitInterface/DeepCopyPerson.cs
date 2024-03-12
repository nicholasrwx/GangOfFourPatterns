public class DeepCopyPerson
{
    public string[] Names;
    public DeepCopyAddress Address;

    public DeepCopyPerson(string[] names, DeepCopyAddress address)
    {
        Names = names ?? throw new ArgumentNullException(paramName: nameof(names));
        Address = address ?? throw new ArgumentNullException(paramName: nameof(address));
    }

    // This is a Copy Constructor
    // It sets the Fields of a new instance from a copied object
    public DeepCopyPerson(DeepCopyPerson other)
    {
        Names = other.Names;
        Address = new DeepCopyAddress(other.Address);
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}\n{nameof(Address)}: ( {Address} )";
    }
}
