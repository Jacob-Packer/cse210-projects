using System.ComponentModel.DataAnnotations;

public class Rectangle : Shape
{
    private double length = 2;
    private double width = 4;
    public override double GetArea()
    {
        return length * width;
    }
}