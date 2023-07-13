public class Lecture : Event
{
    string _speaker;
    int _capacity;

    public Lecture(
        string eventType,
        string title,
        string description,
        string date,
        string time,
        Address address,
        // Not inherited:
        string speaker,
        int capacity
    )
        : base(eventType, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string ListFullDetails()
    {
        return $"{_eventType}: {_title}\n{_description}\n{_date} ({_time})\n{_address.GetAddressString()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
