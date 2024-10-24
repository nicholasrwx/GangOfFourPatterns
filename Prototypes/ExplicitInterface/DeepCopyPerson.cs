public class DeepCopyPerson : IPrototype<DeepCopyPerson>
{
    public string[] Names;
    public DeepCopyAddress Address;

    public DeepCopyPerson(string[] names, DeepCopyAddress address)
    {
        Names = names ?? throw new ArgumentNullException(paramName: nameof(names));
        Address = address ?? throw new ArgumentNullException(paramName: nameof(address));
    }

    public DeepCopyPerson DeepCopy()
    {
        return new DeepCopyPerson(Names, Address.DeepCopy());
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}\n{nameof(Address)}: ( {Address} )";
    }
}
