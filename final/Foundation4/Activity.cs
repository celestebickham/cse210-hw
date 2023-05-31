public abstract class Activity
{
    private string _date;
    protected int _duration;

    public Activity(int duration, string date)
    {
        _date = date;
        _duration = duration;
    }

    protected abstract double GetDistance();
    protected abstract double GetSpeed();
    protected abstract double GetPace();
    public string GetSummary()
    {
        string summnary = $"{GetType()} for {_duration} minutes on {_date}  Details: Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        return summnary;
    }
}