var container = new ContainerBuilder();
container.RegisterType<ReportingService>().Named<IReportingService>("reporting");
container.RegisterDecorator<IReportingService>((context, service) => new ReportingServiceWithLogging(service), "reporting");

using var builtContainer = container.Build();
var result = builtContainer.Resolve<IReportingService>();
result.Report();