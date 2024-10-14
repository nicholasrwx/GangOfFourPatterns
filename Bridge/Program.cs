// Repetitious Dependency Injection
static void CircleInstantiation() {
IRenderer renderer = new RasterRenderer();
var circle = new Circle(renderer, 5);

circle.Draw();
circle.Resize(2);
circle.Draw();
}

// Managed Dependency Injection
static void CircleInstantiationAutofac() {
var cb = new ContainerBuilder();
cb.RegisterType<VectorRenderer>().As<IRenderer>()
.SingleInstance();
cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));

using (var c = cb.Build()) {
    var circle = c.Resolve<Circle>(new PositionalParameter(0, 5.0f));
}
}

CircleInstantiation();
CircleInstantiationAutofac();