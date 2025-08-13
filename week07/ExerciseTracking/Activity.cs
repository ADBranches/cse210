using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public int LengthMinutes
    {
        get { return _lengthMinutes; }
    }

    // Abstract methods to be overridden in derived classes
    public abstract double GetDistance();  // in miles
    public abstract double GetSpeed();     // in miles per hour (mph)
    public abstract double GetPace();      // in minutes per mile

    // Summary method common for all activities
    public virtual string GetSummary()
    {
        // Format date as "dd MMM yyyy"
        string dateStr = _date.ToString("dd MMM yyyy");
        // Name of the derived class (Running, Cycling, Swimming)
        string activityType = this.GetType().Name;
        // Length in minutes
        int length = _lengthMinutes;

        return $"{dateStr} {activityType} ({length} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
