public class WorkerJobBuilder : WorkerBuilder
{
    public WorkerJobBuilder(Worker worker)
    {
        this.worker = worker;
    }

    public WorkerJobBuilder At(string companyName)
    {
        worker.CompanyName = companyName;
        return this;
    }

    public WorkerJobBuilder AsA(string position)
    {
        worker.Position = position;
        return this;
    }

    public WorkerJobBuilder Earning(int annualIncome)
    {
        worker.AnnualIncome = annualIncome;
        return this;
    }
}