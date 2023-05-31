public abstract class Event
{
    protected string _eventTitle;
    private string _eventDescript;
    protected string _eventDate;
    private string _eventTime;
    private Address _eventAddress;


    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        _eventTitle = title;
        _eventDescript = description;
        _eventDate = date;
        _eventTime = time;
        _eventAddress = new Address(street, city, state, country);
    }

    // Methods
    public string GetStandardDetails()
    {
        string details = _eventTitle + "\n" + _eventDescript + "\nDate: " + _eventDate + "\nTime: " + _eventTime + "\nLocation: " + _eventAddress.GetAddress();
        return details;
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();


}