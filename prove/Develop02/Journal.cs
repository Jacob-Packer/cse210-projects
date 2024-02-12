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
        return "a random prompt!";
    }

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
    
    public string GetResponse(prompt)
    {
        // print prompt
        Console.WriteLine($"Prompt: {prompt}");
        // read response
        Console.Write("Record your entry.\n  > ");
        string response = Console.ReadLine();
        return response;
    }
}