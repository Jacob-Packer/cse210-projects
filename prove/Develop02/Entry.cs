using System.Net;

public class Entry 
{
    string prompt;
    string response;
    string date;

    // constructor
    public Entry(string prompt, string response, string date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{prompt}, {response}, {date}");
    }
}