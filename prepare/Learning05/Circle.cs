using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class Circle : Shape
{
    private double radius = 3;
    public override double GetArea()
    {
        return 3.14 * (radius * radius);
    }
}