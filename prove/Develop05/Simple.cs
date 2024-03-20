class Simple : Goal
{
    public bool completed { get; set; }
    public Simple(){}
    public Simple(string name) : base(name){}
    public override string GetProgress()
    {
        return ($"Completed: {completed}");
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
                }
        return GetCompletionScore(); // return number completed now (NOT TOTAL) points per completion
    }
}