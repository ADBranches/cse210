public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private readonly int _target;
    private readonly int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points += _bonus; 
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() =>
        $"[{(IsComplete() ? "X" : " ")}] {_shortName}: {_description} (Completed {_amountCompleted}/{_target})";

    public override string GetStringRepresentation() =>
        $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
}
