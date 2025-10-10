public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, string points, int target, int bonus) : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Congratulations! You completed '{_shortName}' you've earned {_bonus} points.");
        }
        else
        {
            Console.WriteLine($"Progress recorded for '{_shortName}'. {_amountCompleted}/{_target}");
        }
    }
    public override bool IsCompleted()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        return $"{CompletionStatus()} {_shortName} ({_description}) -- Currently Completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted},{IsCompleted()}";
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetProgress(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}