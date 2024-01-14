using System;

class Program
{
    static void Main(string[] args)
    {   
        // Ask user for names
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // Print name
        Console.Write($"Your name is {last_name}, {first_name} {last_name}.");
    }
}