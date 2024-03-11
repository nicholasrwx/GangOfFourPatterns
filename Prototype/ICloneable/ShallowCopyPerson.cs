public class ShallowCopyPerson : ICloneable
{
    public string[] Names;
    public ShallowCopyAddress Address;

    public ShallowCopyPerson(string[] names, ShallowCopyAddress address)
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
        return new ShallowCopyPerson(Names, Address);
    }
}
