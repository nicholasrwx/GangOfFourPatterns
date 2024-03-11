public class DeepCopyPerson : ICloneable
{
    public string[] Names;
    public DeepCopyAddress Address;

    public DeepCopyPerson(string[] names, DeepCopyAddress address)
    {
        Names = names ?? throw new ArgumentNullException(paramName: nameof(names));
        Address = address ?? throw new ArgumentNullException(paramName: nameof(address));
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}\n{nameof(Address)}: ( {Address} )";
    }

    public object Clone()
    {
        return new DeepCopyPerson(Names, (DeepCopyAddress) Address.Clone());
    }
}
