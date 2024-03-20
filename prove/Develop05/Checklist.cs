class Checklist : Goal
{
    public double listLength { get; set; }
    public double timesCompleted { get; set; }
    public Checklist(){}
    public Checklist(string name, double listLength) : base(name)
    {
        this.listLength = listLength;
    }
    public override string GetProgress()
    {
        return ($"Completed {timesCompleted}/{listLength} times");
    }
    public override double ReportProgress()
    {
        Console.Write("How many times completed?\n  >");
        double finished = int.Parse(Console.ReadLine());
        this.timesCompleted = timesCompleted + finished; //Check if that works (completed vs this.completed)
        return finished * GetCompletionScore(); // return number completed now (NOT TOTAL) times points per completion
    }
}