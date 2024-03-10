public class Address
{
    private string StreetName;
    private int HouseNumber;

    public Address(string streetName, int houseNumber)
    {
        
        StreetName = streetName ?? throw new ArgumentNullException(paramName: nameof(streetName));
        HouseNumber = houseNumber > 0 ? houseNumber : throw new ArgumentNullException(paramName: nameof(houseNumber));
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }
}