public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    // Overridden methods
    public override void RecordEvent()
    {
        // Eternal goals are never complete
    }

    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }

    public override string GetDetailsString()
    {
        return $"[∞] {_shortName}: {_description} (eternal)";
    }
}
