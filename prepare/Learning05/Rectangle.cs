using System.ComponentModel.DataAnnotations;

public class Rectangle : Shape
{
    private double length = 2;
    private double width = 4;
    public Rectangle (string color, double length, double width) : base (color)
    {
        this.length = length;
        this.width = width;
    }
    public override double GetArea()
    {
        return length * width;
    }
}