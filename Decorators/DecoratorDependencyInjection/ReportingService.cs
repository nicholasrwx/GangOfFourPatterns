namespace DecoratorDependencyInjection;

public class ReportingService : IReportingService
{
    public void Report()
    {
        WriteLine("Here is your report.");
    }
}