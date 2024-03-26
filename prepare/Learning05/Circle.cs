using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class Circle : Shape
{
    private double radius;
    public Circle (string color, double radius) : base (color)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return 3.14 * (radius * radius);
    }
}