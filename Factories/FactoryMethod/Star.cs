public class Star
{
    private double x, y;

    public static Star NewCartesianCoordinates(double x, double y)
    {
        return new Star(x, y);
    }

    public static Star PolarPoint(double rho, double theta)
    {
        return new Star(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }

    private Star(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
    }
}