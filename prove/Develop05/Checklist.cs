class Checklist : Goal
{
    public override string goalType { get; set; } = "Checklist";
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
    public override string GetProgress()
    {
        return $"Completed {timesCompleted}/{listLength} times";
    }
    public override double ReportProgress()
    {
        Console.Write("How many times completed?\n  >");
        double finished = int.Parse(Console.ReadLine());
        this.timesCompleted = timesCompleted + finished; //Check if that works (completed vs this.completed)
        return finished * GetCompletionScore(); // return number completed now (NOT TOTAL) times points per completion
    }
}