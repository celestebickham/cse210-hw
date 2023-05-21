using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int pointSaved) : base(goalName, goalDescription, pointSaved)
    {
        _title = goalName;
        _description = goalDescription;
        _pointsSaved = pointSaved;
    }

    public override string GetGoalInfo()
    {
        return $"[ ] {_title} ({_description})";
    }

    public override int GetGoalCompleted(int userPoints)
    {
        GetGoalInfo();
        userPoints = userPoints + _pointsSaved;
        return userPoints;
    }

    public override string GetGoalDetails()
    {
        return "EternalGoal:" + _title + "," + _description + "," + _pointsSaved;
    }
}
