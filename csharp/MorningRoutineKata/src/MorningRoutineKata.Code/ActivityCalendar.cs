namespace MorningRoutineKata.Code;

public class ActivityCalendar
{
    private readonly List<Activity> _activities;

    private readonly Activity _defaultActivity = new("No activity", new HourAndMinutes(-1, 0), new HourAndMinutes(-1, 0));

    public ActivityCalendar()
    {
        _activities = new List<Activity>()
        {
            new("Do exercise", new HourAndMinutes(6, 0), new HourAndMinutes(6, 59)),
            new("Read and study", new HourAndMinutes(7, 0), new HourAndMinutes(7, 59)),
            new("Have breakfast", new HourAndMinutes(8, 0), new HourAndMinutes(8, 59))
        };
    }

    public string GetCurrentActivityGiven(DateTime currentTime)
    {
        var currentActivity = _activities.FirstOrDefault(activity => activity.IsActivityFor(currentTime), _defaultActivity);

        return currentActivity.Message();
    }
}