using System.Diagnostics;
using System.Dynamic;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

class GoalsList
{
    public double totalScore { get; set; } = 0;
    public List<Goal> goalsList { get; set; } = new List<Goal>();
    public GoalsList(){}
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
                Console.Write("\nName of checklist: ");
                string checklistName = Console.ReadLine();
                Console.WriteLine("How many times to complete?");
                double length = int.Parse(Console.ReadLine());
                Checklist checklist = new Checklist(checklistName, length);
                goalsList.Add(checklist); //Why Isn't this in the list? When serialized shouldnt it show something?
                break;
            case 2:
                Console.Write("\nName of simple goal: ");
                string simpleName = Console.ReadLine();
                Simple simple = new Simple(simpleName);
                goalsList.Add(simple); 
                break;
        }

    }
    public void DisplayGoals()
    {
        double index = 1;
        foreach (Goal goal in goalsList)
        {
            Console.WriteLine($"[{index}] {goal.GetName()} || {goal.GetProgress()}");
        }
    }
    public double ReportProgress()
    {
        DisplayGoals();
        Console.Write("Which goal to report on?\n  >");
        int choice = int.Parse(Console.ReadLine());
        double pointsGained = goalsList[choice - 1].ReportProgress(); //
        Console.WriteLine($"You gained {pointsGained}");
        
        totalScore += pointsGained;
        DisplayScore();
        return pointsGained;
    }
}