using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Shapes World!");
        
        Square square = new Square();
        string color = square.GetColor();
        double area = square.GetArea();
        Console.WriteLine(color);
        Console.WriteLine(area);
    }
}