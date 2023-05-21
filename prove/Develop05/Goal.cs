using System;

public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _pointsSaved;

    protected List<string> _listOfGoals = new List<string>();

    public Goal(string goalName, string goalDescription, int pointSaved)
    {
        _title = goalName;
        _description = goalDescription;
        _pointsSaved = pointSaved;
    }

    public string GetGoalName()
    {
        return _title;
    }

    public void SetGoalName(string goalName)
    {
        _title = goalName;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _description = goalDescription;
    }

    public int GetGoalPoints()
    {
        return _pointsSaved;
    }

    public void SetGoalPoints(int goalPointsSaved)
    {
        _pointsSaved = goalPointsSaved;
    }

    public virtual string GetGoalInfo()
    {
        return $"[] {_title} ({_description})";
    }

    public virtual string GetGoalInfoShort()
    {
        return $"{_title}";
    }

    public virtual int GetGoalCompleted(int userPoints)
    {
        return userPoints;
    }

    public virtual string GetGoalDetails()
    {
        return "Goal:" + _title + "," + _description + "," + _pointsSaved + "," + false;
    }
}