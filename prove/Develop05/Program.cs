using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Goals Tracking World!");
        GoalsList goalsList = new GoalsList();
        
        goalsList.DisplayScore(); // score: 0 points
        goalsList.SetGoal(); // create checklist
        
        goalsList.ReportProgress(); // choose goal, update points & Display Score

        // Serialize the goalsList object to JSON
        string json = JsonSerializer.Serialize(goalsList);
        Console.WriteLine("\nSerialized GoalsList object:");
        Console.WriteLine(json);
    }
}