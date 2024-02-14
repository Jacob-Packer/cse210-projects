public class Journal
{
    // Declare variables for Journal
    public List<Entry> entries = new List<Entry>();

    string[] prompts = {"prompt 1", "prompt 2", "prompt 3", "prompt 4"};
    

    // constructor: to instantiate
    public Journal(){}

    public string GetRandomPrompt()
    {
        // use Random to get a prompt
        Random rnd = new Random();
        int r = rnd.Next(entries.Count);
        string prompt = prompts[r];
        return prompt;
    }

    
    public string GetResponse(string prompt)

    {
        // print prompt
        Console.WriteLine($"Prompt: {prompt}");
        // read response
        Console.Write("Record your entry.\n  > ");
        string response = Console.ReadLine();
        return response;
    }

    public void ReadFile() {
        // string filename = "myFile.txt"
        Console.WriteLine("Enter the name of the file.");
        Console.Write("  > ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Declare some symbol to split by
            string[] parts = line.Split("|");
            // Date|Prompt|Response
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(prompt, response, date);
            entries.Add(entry);
        }
    }

    public void SaveFile() {
        
        Console.WriteLine("Enter the name of the file.");
        Console.WriteLine("  > ");
        string filename = Console.ReadLine();
        
        // string filename = "myFile.txt";
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("Date|Prompt|Response"); //First line added to file
            
            foreach (Entry entry in entries){
                string stringPrompt = entry.Stringify();
                outputFile.WriteLine(stringPrompt);
            }
        }
    } 

    public void DisplayJournal(){
        // for Entry in entries (display entries)
        Console.WriteLine("Display Entries:");
        foreach (Entry entry in entries)
        {
            // Console.WriteLine($"Entry: {entry}");
            entry.DisplayEntry();
        }
    }
}