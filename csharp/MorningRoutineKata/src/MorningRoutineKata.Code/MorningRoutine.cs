namespace MorningRoutineKata.Code;

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