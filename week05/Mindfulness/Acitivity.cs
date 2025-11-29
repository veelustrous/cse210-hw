using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration; // in seconds

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        Pause(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Great job!");
        Pause(2);
        Console.WriteLine($"{_name} Activity completed! Duration: {_duration} seconds.");
        Pause(3);
    }

    public void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void Spinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds; i++)
        {
            foreach (var s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }
    }
}
