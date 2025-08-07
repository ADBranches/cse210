public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public void SetCompletionStatus(bool isComplete) => _isComplete = isComplete;

    public override void RecordEvent() => _isComplete = true;
    public override bool IsComplete() => _isComplete;
    public override string GetStringRepresentation() =>
        $"SimpleGoal:{_shortName},{_description},{GetPoints()},{_isComplete}";
}
