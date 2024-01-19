using System;
using System.Globalization;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Make A List World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = 0;
        List<int> numbers = new List<int>();
        do {
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
               numbers.Add(num);
                // break;
            }
            // numbers.Add(num);
            // numbers.Add(int.Parse(Console.ReadLine()));
        } while (num != 0);
        Console.WriteLine(numbers);

        // find mathy stuff with list
        int total = 0;
        int bigNumber = 0;
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            //find list sum and find biggest number
            total += number;
            if (number > bigNumber) {
                bigNumber = number;
            }
        }
        float average = total / numbers.Count;

        // print mathy results
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {bigNumber}");
    }
}