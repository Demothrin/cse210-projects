public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
        _name = "Swimming";
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length;
    }
    public override double GetPace()
    {
        return _length / GetDistance();
    }
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;
    }
}