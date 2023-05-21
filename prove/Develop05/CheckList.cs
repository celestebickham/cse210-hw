using System;

public class CheckListGoal : Goal
{

    private int _counterNow;
    private int _counterVerify;
    private int _bonusGoal;
    private int _pointsSaved;
    private bool _checked = false;

    public CheckListGoal(string goalName, string goalDescription, int pointSaved, int counterVerify, int bonusGoal, int counterNow = 0, bool Goalchecked = false) : base(goalName, goalDescription, pointSaved)
    {


        _counterNow = counterNow;
        _counterVerify = counterVerify;
        _bonusGoal = bonusGoal;
        _title = goalName;
        _pointsSaved = pointSaved;
        _checked = Goalchecked;
        _description = goalDescription;
    }

    public int GetCounterVerify()
    {
        return _counterVerify;
    }

    public void SetCounterVerify(int counterVerifyToSet)
    {
        _counterVerify = counterVerifyToSet;
    }
    public int GetbonusGoal()
    {
        return _bonusGoal;
    }
    public void SetbonusGoal(int bonusGoalToSet)
    {
        _bonusGoal = bonusGoalToSet;

    }
    public int GetCounter()
    {
        return _counterNow;
    }
    public void SetCounter(int counterToSet)
    {
        _counterNow = counterToSet;

    }

    public override string GetGoalInfo()
    {
        if (_checked)
        {
            return $"[X] {_title} ({_description}) -- Currently completed {GetCounter()}/{_counterVerify}";
        }
        else
        {
            return $"[ ] {_title} ({_description}) -- Currently completed {GetCounter()}/{_counterVerify}";
        }
    }

    public override int GetGoalCompleted(int userPoints)
    {

        _counterNow = _counterNow + 1;
        int counterNow = _counterNow;
        SetCounter(counterNow);

        string goalInfo = GetGoalInfo();

        int index = _listOfGoals.IndexOf(goalInfo);
        string newGoalInfo;

        if (_counterNow == _counterVerify)
        {
            _checked = true;
            newGoalInfo = GetGoalInfo();

            userPoints = userPoints + _bonusGoal;
            userPoints = userPoints + _pointsSaved;
        }
        else if (_counterNow > _counterVerify)
        {
            _counterNow = _counterNow - 1;
        }
        else
        {
            newGoalInfo = goalInfo;
            userPoints = userPoints + _pointsSaved;
        }

        return userPoints;
    }

    public override string GetGoalDetails()
    {
        return "CheckListGoal:" + _title + "," + _description + "," + _pointsSaved + "," + _counterVerify + "," + _bonusGoal + "," + _counterNow;
    }
}