using System.Net;
using System.Reflection.Metadata.Ecma335;

public class Entry 
{
    string prompt;
    string response;
    string date;

    // constructor
    public Entry(string prompt, string response)
    {
        this.prompt = prompt;
        this.response = response;

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        this.date = dateText;
    }
    //contructor 
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

    // method to retrun string of an entry (prompt, entry, date)
    // return
    public string Stringify(){
        return $"{prompt}|{response}|{date}";
    }

    
}