public abstract class Activity
{
    DateTime _date;
    protected int _minutes;

    public Activity(int minutes)
    {
        _minutes = minutes;

        _date = DateTime.Now;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_minutes} min) - Distance: {Math.Round(GetDistance(), 1, MidpointRounding.AwayFromZero)} km, Speed: {Math.Round(GetSpeed(), 1, MidpointRounding.AwayFromZero)} kph, Pace: {Math.Round(GetPace(), 1, MidpointRounding.AwayFromZero)} min per km";
    }
}
