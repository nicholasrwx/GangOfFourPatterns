public class Worker
{
    // address
    public string StreetAddress, Postcode, City;

    // employment
    public string CompanyName, Position;

    public int AnnualIncome;

    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}\n" +
            $"{nameof(Postcode)}: {Postcode}\n" +
            $"{nameof(City)}: {City}\n" +
            $"{nameof(CompanyName)}: {CompanyName}\n" +
            $"{nameof(Position)}: {Position}\n" +
            $"{nameof(AnnualIncome)}: {AnnualIncome}\n";
    }
}