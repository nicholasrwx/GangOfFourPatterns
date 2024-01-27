public class WorkerAddressBuilder : WorkerBuilder
{
    // might not work with a value type!
    public WorkerAddressBuilder(Worker worker)
    {
        this.worker = worker;
    }

    public WorkerAddressBuilder At(string streetAddress)
    {
        worker.StreetAddress = streetAddress;
        return this;
    }

    public WorkerAddressBuilder WithPostcode(string postcode)
    {
        worker.Postcode = postcode;
        return this;
    }

    public WorkerAddressBuilder In(string city)
    {
       worker.City = city;
        return this;
    }

}