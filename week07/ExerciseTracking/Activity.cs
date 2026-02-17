public abstract class Activity
{
    private string _date;
    private int _duration; //minutes

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min) -" +
        $"Distance {GetDistance():F2} Km, Speed {GetSpeed():F2} k/h, Pace {GetPace():F2} Minutes per Km";
    }
}