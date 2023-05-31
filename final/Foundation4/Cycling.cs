public class Cycling : Activity
{
    private double _speed;

    public Cycling(int duration, string date, double speed) : base(duration, date)
    {
        _speed = speed;
    }
    protected override double GetDistance()
    {
        double distance = (_speed / 60) * base._duration;
        return Math.Round(distance, 2);
    }
    protected override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }
    protected override double GetPace()
    {
        double pace = base._duration / GetDistance();
        return Math.Round(pace, 2);
    }
}