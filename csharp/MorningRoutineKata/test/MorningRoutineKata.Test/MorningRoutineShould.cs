using MoringRoutineKata.Code;

namespace MorningRoutineKata.Test;

public class MorningRoutineShould
{

    [Fact]
    public void DoExerciseAtSix()
    {
        using (var stringWriter = new StringWriter())
        {
            Console.SetOut(stringWriter);

            Clock clock = new ClockStub(6);
            var morningRoutine = new MorningRoutine(clock);

            morningRoutine.WhatShouldIDoNow();

            Assert.Equal("Do exercise", stringWriter.ToString());
        }
    }
    
    [Fact]
    public void ReadAndStudyAtSeven()
    {
        using (var stringWriter = new StringWriter())
        {
            Console.SetOut(stringWriter);

            var clock = new ClockStub(7);
            var morningRoutine = new MorningRoutine(clock);

            morningRoutine.WhatShouldIDoNow();

            Assert.Equal("Read and study", stringWriter.ToString());
        }
    }
    
    [Fact]
    public void HaveBreakfastAtEight()
    {
        using (var stringWriter = new StringWriter())
        {
            Console.SetOut(stringWriter);

            var clock = new ClockStub(8);
            var morningRoutine = new MorningRoutine(clock);

            morningRoutine.WhatShouldIDoNow();

            Assert.Equal("Have breakfast", stringWriter.ToString());
        }
    }
    
    [Fact]
    public void NoActivityInOtherHours()
    {
        using (var stringWriter = new StringWriter())
        {
            Console.SetOut(stringWriter);

            var clock = new ClockStub(9);
            var morningRoutine = new MorningRoutine(clock);

            morningRoutine.WhatShouldIDoNow();

            Assert.Equal("No activity", stringWriter.ToString());
        }
    }
}

public class ClockStub : Clock
{
    private readonly int _hour;

    public ClockStub(int hour)
    {
        this._hour = hour;
    }

    public int GetCurrentHour()
    {
        return _hour;
    }
}