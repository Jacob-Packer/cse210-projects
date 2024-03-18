using System.Data.Common;

class Assignment
{

    private string studentName;
    private string topic;
    public Assignment(string studentName, string topic)
    {
        this.studentName = studentName;
        this.topic = topic;
    }
    public virtual string GetSummary()
    {
        return ($"{studentName} - {topic}");
    }
    public void DisplaySummary()
    {
        Console.WriteLine($"{studentName} - {topic}");
    }

}