public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, string street, string city, string state, string country, string weather) : base(title, description, date, time, street, city, state, country)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        string details = "Outdoor Gathering \n" + base.GetStandardDetails() + "\nWeather Forecast: " + _weather;
        return details;
    }

    public override string GetShortDescription()
    {
        string details = "Outdoor Gathering \n" + base._eventTitle + "\n" + base._eventDate;
        return details;
    }
}