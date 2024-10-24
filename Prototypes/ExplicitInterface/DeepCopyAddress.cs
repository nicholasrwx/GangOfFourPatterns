public class DeepCopyAddress : IPrototype<DeepCopyAddress>
{
    public string StreetName;
    public int HouseNumber;

    public DeepCopyAddress(string streetName, int houseNumber)
    {  
        StreetName = streetName ?? throw new ArgumentNullException(paramName: nameof(streetName));
        HouseNumber = houseNumber > 0 ? houseNumber : throw new ArgumentNullException(paramName: nameof(houseNumber));
    }

    public DeepCopyAddress DeepCopy()
    {
        return new DeepCopyAddress(StreetName, HouseNumber);
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}
