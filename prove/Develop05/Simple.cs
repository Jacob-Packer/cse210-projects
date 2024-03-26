class Simple : Goal
{
    public override string goalType { get; set; } = "Simple";
    public bool completed { get; set; }
    public Simple()
    {
        Console.Write("\nName of simple goal: ");
        string simpleName = Console.ReadLine();
        name = simpleName;
    }
    public override string GetProgress()
    {
        return $"Completed: {completed}";
    }
    public override double ReportProgress()
    {
        Console.Write($"Did you complete {name}? [Y/N]\n  >");
        string finished = Console.ReadLine().ToUpper();
            if (finished == "Y")
                {
                    completed = true;
                }
            else
                {
                    Console.WriteLine("Keep on trying. ");
                }
        return GetCompletionScore(); // return number completed now (NOT TOTAL) points per completion
    }
}