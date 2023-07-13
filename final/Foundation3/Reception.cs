public class Reception : Event
{
    string _email;

    public Reception(
        string eventType,
        string title,
        string description,
        string date,
        string time,
        Address address,
        // Not inherited:
        string email
    )
        : base(eventType, title, description, date, time, address)
    {
        _email = email;
    }

    public override string ListFullDetails()
    {
        return $"{_eventType}: {_title}\n{_description}\n{_date} ({_time})\n{_address.GetAddressString()}\nRSVP at: {_email}";
    }
}
