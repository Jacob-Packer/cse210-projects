using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Class Assignment World!");
        
        Assignment assignment = new Assignment("Samuel bennet",  "Multiplication");
        string student1 = assignment.GetSummary();
        Console.WriteLine(student1);
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string student2 = mathAssignment.GetSummary();
        string homework = mathAssignment.GetHomeworkList();
        Console.WriteLine(student2);
        Console.WriteLine(homework);
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        string student3 = writingAssignment.GetSummary();
        string writinghomework = writingAssignment.GetWritingInformation();
        Console.WriteLine(student3);
        Console.WriteLine(writinghomework);
    }
}