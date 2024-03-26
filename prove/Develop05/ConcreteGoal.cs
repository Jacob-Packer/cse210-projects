using System;

class ConcreteGoal : Goal
{
    // Constructors
    public ConcreteGoal() : base() // Default constructor
    {
    }

    public ConcreteGoal(string name, double completionScore) : base()
    {
        this.name = name;
        this.completionScore = completionScore;
    }

    // Overrides
    public override double ReportProgress()
    {
        // Implement specific progress reporting for ConcreteGoal
        return completionScore * 0.5; // Placeholder implementation
    }

    public override string GetProgress()
    {
        // Implement specific progress string for ConcreteGoal
        return $"Progress for {name}: {ReportProgress()}%"; // Placeholder implementation
    }

    public override string GetGoalType()
    {
        // Override to provide specific goal type for ConcreteGoal
        return "Concrete"; // Placeholder implementation
    }
    public override string goalType { get; set; }
}
