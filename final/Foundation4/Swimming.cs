public class Swimming : Activity
{
    int _laps;

    public Swimming(int minutes, int laps)
        : base(minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Convert.ToDouble(_laps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
}
