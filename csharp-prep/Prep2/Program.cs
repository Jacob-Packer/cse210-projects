using System;

class Program
{
    static void Main(string[] args)
    {
        // Get percentage from user and convert to int
        Console.WriteLine("Please enter a grade percentage: ");
        string textFromUser = Console.ReadLine();
        int percentage = int.Parse(textFromUser);

        // compare percentage on if tree to determine if letter grade changes
        string letterGrade = "A";
        if (percentage < 90)
            letterGrade = "B";
        else if (percentage < 80)
            letterGrade = "C";
        else if (percentage < 70)
            letterGrade = "D";
        else if (percentage < 60)
            letterGrade = "F";

        // print letter grade
        Console.WriteLine($"Your grade is a(n) {letterGrade}.");
    }
}