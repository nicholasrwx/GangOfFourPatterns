public class DeepCopyAddress
{
    public string StreetName;
    public int HouseNumber;

    public DeepCopyAddress(string streetName, int houseNumber)
    {
        
        StreetName = streetName ?? throw new ArgumentNullException(paramName: nameof(streetName));
        HouseNumber = houseNumber > 0 ? houseNumber : throw new ArgumentNullException(paramName: nameof(houseNumber));
    }

    // This is a Copy Constructor
    // It sets the Fields of a new instance from a copied object
    public DeepCopyAddress(DeepCopyAddress other)
    {
        StreetName = other.StreetName;
        HouseNumber = other.HouseNumber;
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}
