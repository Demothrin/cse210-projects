public class RunningActivity : Activity
{
    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
        _name = "Running";
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60;
    }
    public override double GetPace()
    {
        return _length / _distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

}