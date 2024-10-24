namespace DecoratorDependencyInjection;

public class ReportingServiceWithLogging : IReportingService
{
    private IReportingService _decorated;

    public ReportingServiceWithLogging(IReportingService decorated)
    {
        this._decorated = decorated;
    }

    public void Report()
    {
        WriteLine("Starting The Log...");
        _decorated.Report();
        WriteLine("Ending The Log...");
    }
}