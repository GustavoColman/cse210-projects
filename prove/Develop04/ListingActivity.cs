using System;
using System.Threading;

class ListingActivity : MindfulnessActivity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();

        foreach (var prompt in listingPrompts)
        {
            Console.WriteLine(prompt);
            Thread.Sleep(2000);

            Console.WriteLine("Get ready to list...");
            Thread.Sleep(2000);

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            int itemCount = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();

                if (string.IsNullOrEmpty(item))
                    break;

                itemCount++;
            }

            Console.WriteLine($"You listed {itemCount} items.");
        }

        base.PerformActivity();
    }
}


   