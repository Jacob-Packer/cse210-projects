using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.IO.Enumeration;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

class GoalsList
{
    public double totalScore { get; set; }
    public List<string> menuOptions {get; set; }
    public List<Goal> goalsList { get; set; }
    public GoalsList()
    {
        goalsList = new List<Goal>();
        menuOptions = new List<string>(){"Report Progress on a Goal", "Set New Goal", "Show Current Score", "Display All Goals", "Save Goals", "Load Saved Goals File", "Quit"};
        totalScore = 0;
    }
    public void DisplayMenu()
    {
        int index = 1;
        foreach (string option in menuOptions)
        {
            Console.WriteLine($"[{index}] {option}");
            index++;
        }
        
    }
    public double GetScore()
    {
        return totalScore;
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalScore} points");
    }
    public void SetGoal()
    {
        Console.WriteLine("Goal Type?\n[1] Checklist\n[2] Simple\n[3] Eternal ");
        double choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Checklist checklist = new Checklist();
                goalsList.Add(checklist); 
                break;
            case 2:
                Simple simple = new Simple();
                goalsList.Add(simple); 
                break;
            case 3:
                Eternal eternal = new Eternal();
                goalsList.Add(eternal); 
                break;
        }

    }
    public void DisplayGoals()
    {
        double index = 1;
        foreach (Goal goal in goalsList)
        {
            Console.WriteLine($"[{index}] {goal.GetName()} |({goal.GetGoalType()})| {goal.GetProgress()}");
            index++;
        }
    }
    public double ReportProgress()
    {
        DisplayGoals();
        Console.Write("Which goal to report on?\n  >");
        int choice = int.Parse(Console.ReadLine());
        double pointsGained = goalsList[choice - 1].ReportProgress(); 
        Console.WriteLine($"You gained {pointsGained}");
        
        totalScore += pointsGained;
        DisplayScore();
        return pointsGained;
    }
}




