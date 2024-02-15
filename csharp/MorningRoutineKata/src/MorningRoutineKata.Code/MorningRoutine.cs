namespace MorningRoutineKata.Code;

public class ActivityCalendar
{
    private readonly List<Activity> _activities;

    private readonly Activity _defaultActivity = new("No activity", -1);

    public ActivityCalendar()
    {
        _activities = new List<Activity>()
        {
            new("Do exercise", 6),
            new("Read and study", 7),
            new("Have breakfast", 8)
        };
    }

    public string GetCurrentActivityGiven(DateTime currentTime)
    {
        var currentActivity = _activities.FirstOrDefault(activity => activity.IsActivityFor(currentTime), _defaultActivity);

        return currentActivity.Message();
    }
}

public class Activity
{
    private readonly string _message;
    private readonly int _hour;

    public Activity(string message, int hour)
    {
        _message = message;
        _hour = hour;
    }

    public string Message()
    {
        return _message;
    }

    public bool IsActivityFor(DateTime currentTime)
    {
        return _hour == currentTime.Hour;
    }
}

public class MorningRoutine
{
    private readonly Clock _clock;
    private readonly ActivityCalendar _activityCalendar;

    public MorningRoutine(Clock clock)
    {
        _clock = clock;
        _activityCalendar = new ActivityCalendar();
    }

    public void WhatShouldIDoNow()
    {
        var currentActivity = _activityCalendar.GetCurrentActivityGiven(_clock.GetCurrentTime());

        Console.Write(currentActivity);
    }
}