namespace MorningRoutineKata.Code;

public class Activity
{
    private readonly string _message;
    private readonly ActivityInterval _interval;

    public Activity(string message, HourAndMinutes start, HourAndMinutes end)
    {
        _message = message;
        _interval = new ActivityInterval(start, end);
    }

    public string Message()
    {
        return _message;
    }

    public bool IsActivityFor(DateTime currentTime)
    {
        return _interval.MatchWith(currentTime);
    }
}

public class ActivityInterval
{
    private readonly HourAndMinutes _start;
    private readonly HourAndMinutes _end;

    public ActivityInterval(HourAndMinutes start, HourAndMinutes end)
    {
        _start = start;
        _end = end;
    }

    public bool MatchWith(DateTime currentTime)
    {
        var currentTimeAsHourAndMinutes = new HourAndMinutes(currentTime.Hour, currentTime.Minute);
        
        return _start <= currentTimeAsHourAndMinutes && _end >= currentTimeAsHourAndMinutes;
    }
    
}

public record HourAndMinutes(int Hour, int Minutes)
{
    public static bool operator <(HourAndMinutes a, HourAndMinutes b)
    {
        if (a.Hour > b.Hour)
        {
            return false;
        }

        if (a.Minutes > b.Hour)
        {
            return false;
        }

        if (a.Hour == b.Hour && a.Minutes == b.Minutes)
        {
            return false;
        }

        return true;
    }
    
    public static bool operator >(HourAndMinutes a, HourAndMinutes b)
    {
        if (a.Hour < b.Hour)
        {
            return false;
        }

        if (a.Minutes < b.Hour)
        {
            return false;
        }

        if (a.Hour == b.Hour && a.Minutes == b.Minutes)
        {
            return false;
        }

        return true;
    }
    
    public static bool operator <=(HourAndMinutes a, HourAndMinutes b)
    {
        if (a.Hour > b.Hour)
        {
            return false;
        }

        if (a.Minutes > b.Hour)
        {
            return false;
        }

        return true;
    }
    
    public static bool operator >=(HourAndMinutes a, HourAndMinutes b)
    {
        if (a.Hour < b.Hour)
        {
            return false;
        }

        if (a.Minutes < b.Hour)
        {
            return false;
        }

        return true;
    }
};