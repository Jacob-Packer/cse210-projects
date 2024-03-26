using System;
using System.Drawing;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Shapes World!");
        
        List<Shape> shapes = new List<Shape>();

        Rectangle rectangle = new Rectangle("red", 2,3);
        Circle circle = new Circle("black", 1);
        Square square = new Square("blue", 2);
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
        }        
    }
}