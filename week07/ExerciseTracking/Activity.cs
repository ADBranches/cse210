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

    public abstract double GetDistance();  
    public abstract double GetSpeed();    
    public abstract double GetPace();      

    public virtual string GetSummary()
    {
        string dateStr = _date.ToString("dd MMM yyyy");
        string activityType = this.GetType().Name;
        int length = _lengthMinutes;

        return $"{dateStr} {activityType} ({length} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
