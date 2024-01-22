using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    DateTime theCurrentTime = DateTime.Now;
                    string currentDate = theCurrentTime.ToShortDateString();

                    Prompts prompts = new Prompts();
                    string randomPrompt = prompts.RandomPrompt();

                    journal.AddEntry(currentDate, randomPrompt);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the file name to load from: ");
                    string loadFileName = Console.ReadLine();
                    string loadFilePath = Path.Combine(Directory.GetCurrentDirectory(), loadFileName);
                    journal.LoadFromFile(loadFilePath);
                    break;
                case "4":
                    Console.Write("Enter the file name to save to: ");
                    string saveFileName = Console.ReadLine();
                    string fullFilePath = Path.Combine(Directory.GetCurrentDirectory(), saveFileName);
                    journal.SaveToFile(fullFilePath);
                    break;
                case "5":
                    Console.WriteLine("Quitting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}