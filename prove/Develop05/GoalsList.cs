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
    public void SaveFile() 
    {
        // Serialize the goalsList object to JSON
        // string json = JsonSerializer.Serialize(GoalsList);
        // Console.WriteLine("\nSerialized GoalsList object:");
        // Console.WriteLine(json);
                            
        Console.WriteLine("Enter the name of the file.");
        Console.Write("  > ");
        string filename = Console.ReadLine();

        Console.WriteLine("Saving to file...");
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {foreach (Goal goal in goalsList)
            {
                // You can add text to the file with the WriteLine method
                // outputFile.WriteLine(json);

                // Use the manual method:
                outputFile.WriteLine(goal.GetGoalHash());
            }
        }
    }
        
    public void ReadFile() 
    {
        // // string filename = "myFile.txt"
        Console.WriteLine("Enter the name of the file.");
        Console.Write("  > ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        // string json = System.IO.File.ReadAllText(filename);

        // // Deserialize the JSON back into the list object
        // GoalsList goalsList = JsonSerializer.Deserialize<GoalsList>(json);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];

            if (goalType == "CHECKLIST")
            {
                // string goalType        = parts[0];
                string name            =           parts[1];
                double completionScore = int.Parse(parts[2]);
                double listLength      = int.Parse(parts[3]);
                double timesCompleted  = int.Parse(parts[4]);
                goalsList.Add(new Checklist(name,completionScore,listLength,timesCompleted));
                // $"{goalType}:{name}:{completionScore}:{listLength}:{timesCompleted}"

            }
            if (goalType == "SIMPLE")
            {
                // string goalType        = parts[0];
                string name            = parts[1];
                double completionScore;
                double.TryParse(parts[2], out completionScore);
                string boolNamespace = parts[3];
                bool completed;
                bool.TryParse(boolNamespace, out completed);
                goalsList.Add(new Simple(name, completionScore, completed));
                
                // $"{goalType}:{name}:{completionScore}"

            }
            if (goalType == "ETERNAL")
            {
                // string goalType        = parts[0];
                string name            =           parts[1];
                double completionScore = int.Parse(parts[2]);
                double timesCompleted  = int.Parse(parts[3]);
                goalsList.Add(new Eternal(name, completionScore, timesCompleted));
            }
                // $"{goalType}:{name}:{completionScore}"

        }
    }
    
}




