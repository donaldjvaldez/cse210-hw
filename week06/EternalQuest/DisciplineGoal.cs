// Showing Creativity and Exceeding Requirements: I decided to make an extra class for those goals that needs discipline thru the time, 
// this class as the other 3 Goal classes inherit part of its behavior from the base Goal class, adapting some of them to its own needs.

public class DisciplineGoal : Goal
{
    private int _amountCompleted;
    private int _targetDuration;
    private int _bonus;
    private bool _isComplete;

    public DisciplineGoal(string shortName, string description, int points, int targetDuration, int bonus)
    : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _targetDuration = targetDuration;
        _bonus = bonus;
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _amountCompleted++;
            Console.WriteLine($"Progress recorded! You earned {GetPoints()} points.");

            if (_amountCompleted >= _targetDuration)
            {
                _isComplete = true;
                Console.WriteLine($"Amazing discipline! You completed the goal and earned a bonus of {_bonus} points!");

            }
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName()} ({GetDescription()}) -- Progress: {_amountCompleted}/{_targetDuration}";
    }
    public override string GetStringRepresentation()
    {
        return $"DisciplineGoal: {GetShortName()}, {GetDescription()}, {GetPoints()}, {_amountCompleted}, {_targetDuration}, {_bonus}, {_isComplete}";
    }

    public int GetAmountCompleted() => _amountCompleted;
    public int GetTargetDuration() => _targetDuration;
}