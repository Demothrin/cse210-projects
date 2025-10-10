public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, string points) : base(name, desc, points)
    {

    }

    public override void RecordEvent()
    {
        
    }
    public override bool IsCompleted()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}