public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, string date, string time, string street, string city, string state, string country, string email) : base(title, description, date, time, street, city, state, country)
    {
        _rsvpEmail = email;
    }
    public override string GetFullDetails()
    {
        string details = "Reception \n" + base.GetStandardDetails() + "\nRSVP Email: " + _rsvpEmail;
        return details;
    }

    public override string GetShortDescription()
    {
        string details = "Reception \n" + base._eventTitle + "\n" + base._eventDate;
        return details;
    }
}