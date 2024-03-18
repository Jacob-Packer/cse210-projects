using System.Formats.Tar;

class Square : Shape
{
    private double side = 1;
    public override double GetArea()
    {
        return side * side;
    }
}