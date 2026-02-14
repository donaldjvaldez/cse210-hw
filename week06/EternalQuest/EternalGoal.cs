using System.Net.NetworkInformation;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Great Job! You earned {GetPoints()} points.");
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetShortName()}, {GetDescription()}, {GetPoints()}";
    }
}