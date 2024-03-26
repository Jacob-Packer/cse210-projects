using System.ComponentModel;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

abstract class Goal
{
    public abstract string goalType {get; set; }
    public string name { get; set; }
    public double completionScore { get; set; } = 100;
    public Goal(){}
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
    public virtual string GetGoalType()
    {
        return goalType;
    }
}