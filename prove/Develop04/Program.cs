using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Program");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Journaling Activity");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an activity (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 5)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            MindfulnessActivity selectedActivity;

            switch (choice)
            {
                case 1:
                    selectedActivity = new BreathingActivity();
                    break;
                case 2:
                    selectedActivity = new ReflectionActivity();
                    break;
                case 3:
                    selectedActivity = new ListingActivity();
                    break;
                case 4:
                    selectedActivity = new GratitudeJournalingActivity();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    continue;
            }

            selectedActivity.StartActivity();
        }
    }
}
    
