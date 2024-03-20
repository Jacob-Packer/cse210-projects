using System.ComponentModel;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

 abstract class Goal
{
    public string name { get; set; }
    public double completionScore { get; set; } = 100;
    public Goal(){}
    public Goal(string name)
    {
        this.name = name.ToUpper();

    }
    public string GetName()
    {
        return name;
    }
    public double GetCompletionScore()
    {
        return completionScore;
    }
    public abstract double ReportProgress();
    public abstract string GetProgress();
}