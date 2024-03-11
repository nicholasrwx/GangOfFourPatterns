// This is a reference type that doesn't implement ICloneable
// Cloning the parent class will copy the reference to this child class
// Ultimately changing the values in the Clone will mutate the values in the original instance

public class ShallowCopyAddress
{
    public string StreetName;
    public int HouseNumber;

    public ShallowCopyAddress(string streetName, int houseNumber)
    {
        
        StreetName = streetName ?? throw new ArgumentNullException(paramName: nameof(streetName));
        HouseNumber = houseNumber > 0 ? houseNumber : throw new ArgumentNullException(paramName: nameof(houseNumber));
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}
