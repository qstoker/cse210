public abstract class Event
{
    protected string _eventType;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(
        string eventType,
        string title,
        string description,
        string date,
        string time,
        Address address
    )
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string ListShortDetails()
    {
        return $"{_eventType}: {_title}, on {_date}";
    }

    public string ListStandardDetails()
    {
        return $"{_title}\n{_description}\n{_date} ({_time})\n{_address.GetAddressString()}";
    }

    public abstract string ListFullDetails();
}
