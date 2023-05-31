public class Swimming : Activity
{
    private int _laps;

    public Swimming(int duration, string date, int laps) : base(duration, date)
    {
        _laps = laps;
    }
    protected override double GetDistance()
    {
        double distance = ((_laps) * 50 / 1000 * 0.62);
        return Math.Round(distance, 2);
    }
    protected override double GetSpeed()
    {
        double speed = (GetDistance() / base._duration) * 60;
        return Math.Round(speed, 2);
    }

    protected override double GetPace()
    {
        double pace = base._duration / GetDistance();
        return Math.Round(pace, 2);
    }
}