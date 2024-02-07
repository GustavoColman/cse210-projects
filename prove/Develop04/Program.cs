using System;

//program main class
class Program
{
    //main method of the program
    static void Main(string[] args)
    {
        //print the frase
        Console.WriteLine("Mindfulness Program");

        // create a loop for a menu
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
                // program shut down
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            MindfulnessActivity selectedActivity;

            switch (choice)
            //"switch" always works with the key word "case" and help to
            //select one of the options
            {
                //calls the breathingactivity class
                case 1:
                //create a new instance to the class breathing activity and
                //atributed on selectedactivity variable
                    selectedActivity = new BreathingActivity();
                    break;
                    //new is a key world to create a new class stance, and
                    //BreathingActivity() is the class constructor
                    //whem i type BreathingActivity() i am calling the class
                    //constructor and create a new class object 

                    
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
    
