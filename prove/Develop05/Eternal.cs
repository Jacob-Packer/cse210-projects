
class Eternal : Goal
{
    public override string goalType { get; set; } = "Eternal";
    public double timesCompleted { get; set; }
    public Eternal()
    {
        Console.Write("\nName of eternal goal: ");
        string eternalName = Console.ReadLine();
        name = eternalName.ToUpper();
    }
    public Eternal(string name, double completionScore, double timesCompleted)
    {
        this.name = name;
        this.completionScore = completionScore;
        this. timesCompleted = timesCompleted;
    }
    public override string GetProgress()
    {
        return $"Completed {timesCompleted} times";
    }
    public override double ReportProgress()
    {
        Console.Write("How many times completed?\n  >");
        double finished = int.Parse(Console.ReadLine());
        this.timesCompleted = timesCompleted + finished; //Check if that works (completed vs this.completed)
        return finished * GetCompletionScore(); // return number completed now (NOT TOTAL) times points per completion
    }
    public override string GetGoalHash()
    {
        return $"{goalType}:{name}:{completionScore}:{timesCompleted}";
    }
}