public abstract class Goal
{
    private string _shorName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shorName = shortName;
        _description = description;
        _points = points;
    }

    public string GetShortName()
    {
        return _shorName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shorName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}