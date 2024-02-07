using System;
using System.Threading;

class GratitudeJournalingActivity : MindfulnessActivity
{
    public GratitudeJournalingActivity() : base("Gratitude Journaling", "This activity will help you focus on the positive aspects of your life by journaling things you are grateful for.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Think about things you are grateful for...");
        Thread.Sleep(2000);
        Console.WriteLine("Get ready to start journaling...");
        Thread.Sleep(2000);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int entryCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("Write a gratitude entry: ");
            string entry = Console.ReadLine();

            if (string.IsNullOrEmpty(entry))
                break;

            entryCount++;
        }

        Console.WriteLine($"You wrote {entryCount} gratitude entries.");


        base.PerformActivity();
    }
}