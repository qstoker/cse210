public class OutdoorGathering : Event
{
    string _weather;

    public OutdoorGathering(
        string eventType,
        string title,
        string description,
        string date,
        string time,
        Address address,
        // Not inherited:
        string weather
    )
        : base(eventType, title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string ListFullDetails()
    {
        return $"{_eventType}: {_title}\n{_description}\n{_date} ({_time})\n{_address.GetAddressString()}\nForcasted weather: {_weather}";
    }
}
