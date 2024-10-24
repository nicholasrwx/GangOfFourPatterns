// Implementing ICloneable on a nested reference type will force a deep copy
// However the Interface was meant for Shallow Copies, and will misleads developers as it goes against documentation

public class DeepCopyAddress : ICloneable
{
    public string StreetName;
    public int HouseNumber;

    public DeepCopyAddress(string streetName, int houseNumber)
    {
        
        StreetName = streetName ?? throw new ArgumentNullException(paramName: nameof(streetName));
        HouseNumber = houseNumber > 0 ? houseNumber : throw new ArgumentNullException(paramName: nameof(houseNumber));
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }

    public object Clone()
    {
        return new DeepCopyAddress(StreetName, HouseNumber);
    }
}
