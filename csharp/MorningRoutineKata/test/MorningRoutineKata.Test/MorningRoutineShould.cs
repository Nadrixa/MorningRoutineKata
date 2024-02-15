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
        
            var morningRoutine = new MorningRoutine();

            morningRoutine.WhatShouldIDoNow();

            Assert.Equal("Do exercise", stringWriter.ToString());
        }
    }
}