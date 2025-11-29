using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through slow breathing.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            for (int i = 0; i < 4 && elapsed < duration; i++, elapsed++) { Thread.Sleep(1000); }
            Console.WriteLine("Breathe out...");
            for (int i = 0; i < 6 && elapsed < duration; i++, elapsed++) { Thread.Sleep(1000); }
        }

        DisplayEndMessage();
    }
}
