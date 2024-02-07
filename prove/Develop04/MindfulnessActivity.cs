using System;
using System.Threading;

class MindfulnessActivity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _duration;

    public MindfulnessActivity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
        _duration = 0;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName} activity...");
        Console.WriteLine(_activityDescription);

        SetDuration();
        PrepareForActivity();

        PerformActivity();

        FinishActivity();
    }

    protected virtual void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void PrepareForActivity()
    {
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000);
    }

    protected virtual void PerformActivity()
    {
        Console.WriteLine($"Performing {_activityName} activity for {_duration} seconds...");
        Thread.Sleep(_duration * 1000);
    }

    protected void FinishActivity()
    {
        Console.WriteLine("Great job! Activity completed.");
        Console.WriteLine($"You have completed {_activityName} for {_duration} seconds.");
        Thread.Sleep(2000);
    }
}