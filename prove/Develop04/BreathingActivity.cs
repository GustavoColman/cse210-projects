using System;
using System.Threading;

//this is a base class, but also took propieties from other
//base class mindfullnessactivity
class BreathingActivity : MindfulnessActivity
{

    //this are constructors, they will set the parameters for mindfulnessactivity
    //mrtod on mindfulnessactivity.cs line 20
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Breathe in...");
        Thread.Sleep(_duration * 500); // Pause for half of the specified duration
        Console.WriteLine("Breathe out...");
        Thread.Sleep(_duration * 500); // Pause for half of the specified duration

        base.PerformActivity();
    }
}
