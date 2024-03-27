class Checklist : Goal
{
    public override string goalType { get; set; } = "CHECKLIST";
    public double listLength { get; set; }
    public double timesCompleted { get; set; }
    public Checklist()
    {
        Console.Write("\nName of checklist: ");
        string checklistName = Console.ReadLine();
        Console.WriteLine("How many times to complete?");
        double length = int.Parse(Console.ReadLine());
        listLength = length;
        name = checklistName.ToUpper();
    }
    public Checklist(string name, double completionScore, double listLength, double timesCompleted)
    {
        this.name = name;
        this.completionScore = completionScore;
        this.listLength = listLength;
        this.timesCompleted = timesCompleted;
    }
    public override string GetProgress()
    {
        return $"Completed {timesCompleted}/{listLength} times";
    }
    public string GetProgressHash()
    {
        return $"{timesCompleted}/{listLength}";
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
        return $"{goalType}:{name}:{completionScore}:{listLength}:{timesCompleted}";
    }
}