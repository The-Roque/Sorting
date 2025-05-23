using System;
using System.Collections.Generic;
using System.Diagnostics;
public class SortingMeasurements
{
    public int Comparisons = 0;
    public int Assignments = 0;
    public int Swaps = 0;
    public TimeSpan ElapsedTime { get; private set; }

    private Stopwatch stopwatch = new Stopwatch();
    public void Reset()
    {
        Comparisons = 0;
        Assignments = 0;
        Swaps = 0;
        ElapsedTime = TimeSpan.Zero;
    }

    public void StartTimer()
    {
        stopwatch.Restart();
    }

    public void StopTimer()
    {
        stopwatch.Stop();
        ElapsedTime = stopwatch.Elapsed;
    }
    public void Print(string sortName)
    {
        Console.WriteLine($"--- {sortName} ---");
        Console.WriteLine($"Comparisons: {Comparisons}");
        Console.WriteLine($"Assignments: {Assignments}");
        Console.WriteLine($"Swaps: {Swaps}");
        Console.WriteLine($"Runtime: {ElapsedTime}");
        Console.WriteLine();
    }
}