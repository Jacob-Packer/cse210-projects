using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Class Assignment World!");
        Assignment assignment = new Assignment("Samuel bennet",  "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

    }
}