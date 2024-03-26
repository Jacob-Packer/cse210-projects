using System;
using System.Reflection;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Goals Tracking World!");

        GoalsList goalsList;
        string filename = "goals.txt";
        
        if (File.Exists(filename))
        {
            string jsonFromFile = File.ReadAllText(filename);
            goalsList = JsonSerializer.Deserialize<GoalsList>(jsonFromFile);
        }
        else
        {
            goalsList = new GoalsList();
        }
        
        while (true)
        {
            goalsList.DisplayMenu();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: // "Report Progress on a Goal"
                    goalsList.ReportProgress();
                    break;
                case 2: //"Set New Goal",
                    goalsList.SetGoal();
                    break;
                case 3: //  "Show Current Score",
                    goalsList.DisplayScore();
                    break;
                case 4: //  "Display All Goals",
                    goalsList.DisplayGoals();
                    break;
                case 5: //Save Goals
                    string jsonString = JsonSerializer.Serialize(goalsList);
                    File.WriteAllText(filename,jsonString);
                    // SaveFile();
                    break;
                case 6: //  "Load Saved Goals File"
                    // ReadFile();
                    Console.WriteLine(@"This should happen automatically from file: prove\Develop05\goals.txt");
                    break;       
                case 7: // Quit   
                    Environment.Exit(0);
                    break;          
                default:
                    Console.WriteLine("Enter a valid option.");
                    break;
            }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadLine();
        }       
    }
}   


    // static void SaveFile() 
    // {
    //     // Serialize the goalsList object to JSON
    //     string json = JsonSerializer.Serialize(GoalsList);
    //     Console.WriteLine("\nSerialized GoalsList object:");
    //     Console.WriteLine(json);
                            
    //     Console.WriteLine("Enter the name of the file.");
    //     Console.Write("  > ");
    //     string filename = Console.ReadLine();

    //     Console.WriteLine("Saving to file...");
        
    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         // You can add text to the file with the WriteLine method
    //         outputFile.WriteLine(json); 
    //     }
    // }
        
    // static void ReadFile() 
    // {
    //     // // string filename = "myFile.txt"
    //     Console.WriteLine("Enter the name of the file.");
    //     Console.Write("  > ");
    //     string filename = Console.ReadLine();

    //     string json = System.IO.File.ReadAllText(filename);

    //     // Deserialize the JSON back into the list object
    //     GoalsList goalsList = JsonSerializer.Deserialize<GoalsList>(json);
    // }