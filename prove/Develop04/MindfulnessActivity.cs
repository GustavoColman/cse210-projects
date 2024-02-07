using System;
using System.Threading;


//this is the super class,or, base class, all the other classes will call it
//and earn his objects, propeties and all
class MindfulnessActivity
{
    //these are fields ( variables), and they are privated by the ACESS MODIFIER "protected"
    //and can be acessed only in theyr omw classes or subclasses
    protected string _activityName;
    protected string _activityDescription;
    protected int _duration;

    // this is the class constructor, he receive parameters from the
    //object constructor EX:  breathingactivity line 11

    //When an object of the MindfulnessActivity class is created,
    // this constructor is called and initializes the fields (variables)
    public MindfulnessActivity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
        _duration = 0;
    }

//here we are useing polimorfism, and that part i not
//undestand very well yet, abimael worked on that part...
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