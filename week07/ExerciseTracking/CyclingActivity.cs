public class CyclingActivity : Activity
{
    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
        _name = "Cycling";
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return _length / GetDistance();
    }
    public override double GetDistance()
    {
        return _speed * (_length / 60);
    }
}