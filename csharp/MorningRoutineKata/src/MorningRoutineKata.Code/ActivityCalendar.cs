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