public class Running : Activity
{
    private double _distance;

    public Running(int duration, string date, double distance) : base(duration, date)
    {
        _distance = distance;
    }
    protected override double GetDistance()
    {
        return _distance;
    }
    protected override double GetSpeed()
    {
        double speed = Math.Round((_distance / base._duration) * 60, 1);
        return speed;
    }
    protected override double GetPace()
    {
        double pace = Math.Round(base._duration / _distance, 2);
        return pace;
    }
}