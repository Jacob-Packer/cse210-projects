using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Fraction Learning Class World!");
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6,7);
        Fraction f4 = new Fraction();

        string f1Fraction = f1.GetFractionString();
        double f1Decimal = f1.GetDecimalValue();
        string f2Fraction = f2.GetFractionString();
        double f2Decimal = f2.GetDecimalValue();
        string f3Fraction = f3.GetFractionString();
        double f3Decimal = f3.GetDecimalValue();

        Console.WriteLine();
        Console.WriteLine(f2Fraction);
        Console.WriteLine(f2Decimal);
        Console.WriteLine(f3Fraction);
        Console.WriteLine(f3Decimal);
        Console.WriteLine();


        int f4Bottom = f4.GetBottom();
        Console.WriteLine(f4Bottom);
        f4.SetTop(20);
        int f4Top = f4.GetTop();
        Console.WriteLine(f4Top);
        f4.GetDecimalValue();
        f4.GetFractionString();
    }
}