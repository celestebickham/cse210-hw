public abstract class Event
{
    protected string _eventTitle;
    private string _eventdescript;
    protected string _eventdate;
    private string _eventtime;
    private Address _eventaddress;


    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        this._eventTitle = title;
        this._eventdescript = description;
        this._eventdate = date;
        this._eventtime = time;
        this._eventaddress = new Address(street, city, state, country);
    }

    // Methods
    public string GetStandardDetails()
    {
        string details = _eventTitle + "\n" + _eventdescript + "\nDate: " + _eventdate + "\nTime: " + _eventtime + "\nLocation: " + _eventaddress.GetAddress();
        return details;
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();


}