namespace BlazorWebAssemblyCanvas.Models;

public class Vector
{
    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double GetDistance(Vector v)
    {
        double dx = X - v.X;
        double dy = Y - v.Y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    public double X { get; set; }
    public double Y { get; set; }
}
