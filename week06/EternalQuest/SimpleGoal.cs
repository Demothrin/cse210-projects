public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string desc, string points) : base(name, desc, points)
    {
        _isCompleted = false;
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
    }
    public override bool IsCompleted() 
    {
        return _isCompleted;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_isCompleted}";
    }
    
}