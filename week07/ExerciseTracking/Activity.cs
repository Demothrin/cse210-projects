using Microsoft.Win32.SafeHandles;

public abstract class Activity
{
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _date;
    protected int _length;
    protected string _name;

    protected Activity(string date, int minutes)
    {
        _date = date;
        _length = minutes;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_length} mins)- Distance {GetDistance():0.00} miles, Speed {GetSpeed():0.00} mph, Pace {GetPace():0.00} min per mile.";
    }
    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract double GetDistance();

}