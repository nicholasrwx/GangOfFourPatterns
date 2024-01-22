public class WorkerBuilder // facade 
{
    // the object we're going to build
    protected Worker worker = new Worker(); // this is a reference and cannot be used in a struct!

    public WorkerAddressBuilder Lives => new WorkerAddressBuilder(worker);
    public WorkerJobBuilder Works => new WorkerJobBuilder(worker);

    // This is an implicit conversion operator
    // This allows you to set the type of a WorkerBuilder to type Worker when declaring a variable
    // This essentially returns the contained Worker Object from within the WorkerBuilder
    // instead of the derived type ( A Sub Builder )
    public static implicit operator Worker(WorkerBuilder wb)
    {
        return wb.worker;
    }
}