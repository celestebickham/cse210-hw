using System;


public class SimpleGoal : Goal
{
    private bool _checked = false;
    private bool _completed = false;

    public SimpleGoal(string goalName, string goalDescription, int pointSaved, bool checkedGoal = false) : base(goalName, goalDescription, pointSaved)
    {
        _title = goalName;
        _description = goalDescription;
        _pointsSaved = pointSaved;
        _checked = checkedGoal;
    }

    public override string GetGoalInfo()
    {
        {
            if (_checked)
            {
                _completed = true;
                return "[X] " + _title + " (" + _description + ")";
            }

            else
            {
                return "[ ] " + _title + " (" + _description + ")";
            }
        }
    }

    public override int GetGoalCompleted(int userPoints)
    {
        bool completed = _completed;

        _checked = true;

        if (completed == false)
        {
            GetGoalInfo();

            userPoints = userPoints + _pointsSaved;
            completed = true;
            return userPoints;
        }

        else
        {
            GetGoalInfo();
            return userPoints;
        }
    }

    public override string GetGoalDetails()
    {
        return "SimpleGoal:" + _title + "," + _description + "," + _pointsSaved + "," + _checked;
    }
}

