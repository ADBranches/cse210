using System;

public class Running : Activity
{
    private double _distanceMiles;

    public Running(DateTime date, int lengthMinutes, double distanceMiles) : base(date, lengthMinutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return _distanceMiles;
    }

    public override double GetSpeed()
    {
        // Speed = distance / time(hours)
        return GetDistance() / (LengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        // Pace = minutes per mile
        return LengthMinutes / GetDistance();
    }
}
