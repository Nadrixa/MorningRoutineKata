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

        if (hour == 7)
        {
            Console.Write("Read and study");
            return;
        }
        
        Console.Write("Do exercise");
    }
}