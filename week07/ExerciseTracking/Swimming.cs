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
        // Distance in miles = laps * 50 meters * meters to miles conversion
        return _numLaps * LapLengthMeters * MetersToMiles;
    }

    public override double GetSpeed()
    {
        // Speed = distance / hours
        return GetDistance() / (LengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        // Pace = minutes per mile
        return LengthMinutes / GetDistance();
    }
}
