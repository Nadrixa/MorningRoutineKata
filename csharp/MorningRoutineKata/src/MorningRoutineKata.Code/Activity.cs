namespace MorningRoutineKata.Code;

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