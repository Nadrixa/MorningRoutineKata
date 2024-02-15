namespace MoringRoutineKata.Code;

public class MorningRoutine
{
    private readonly Clock _clock;

    public MorningRoutine(Clock clock)
    {
        _clock = clock;
    }

    public void WhatShouldIDoNow()
    {
        var hour = _clock.GetCurrentHour();

        if (hour == 6)
        {
            Console.Write("Do exercise");
            return;
        }
        
        if (hour == 7)
        {
            Console.Write("Read and study");
            return;
        }
        
    }
}