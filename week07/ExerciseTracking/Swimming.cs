using System;

public class Swimming : Activity
{
    private int _numLaps;
    private const double LapLengthMeters = 50.0;
    private const double MetersToMiles = 0.000621371;

    public Swimming(DateTime date, int lengthMinutes, int numLaps) : base(date, lengthMinutes)
    {
        _numLaps = numLaps;
    }

    public override double GetDistance()
    {
        return _numLaps * LapLengthMeters * MetersToMiles;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (LengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }
}
