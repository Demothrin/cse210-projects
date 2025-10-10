using System.ComponentModel;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string desc, string points)
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsCompleted();

    public virtual string GetDetailsString()
    {
        return $"{CompletionStatus()} {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
    public string GetName()
    {
        return _shortName;
    }
    public string CompletionStatus()
    {
        if (IsCompleted())
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
    public int GetPoints()
    {
        return int.Parse(_points);
    }
}