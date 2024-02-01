using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        bool programStatus = true;
        string userChoice;

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("Be thou ahumble; and the Lord thy God shall blead thee by the hand, and give thee answer to thy prayers.\n", new Reference("Doctrine & Convenants", 112, 10)),
            new Scripture("And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.\n", new Reference("Mosiah", 2, 17)),
            new Scripture("For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.\n", new Reference("Moses", 1, 39)),
            new Scripture("Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.\n", new Reference("John", 3, 5)),
            new Scripture("Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets.\n", new Reference("Amos", 3, 7))
        };

        Scripture currentScripture = scriptures[0];

        currentScripture.Display();

        while (programStatus)
        {
            Console.WriteLine("\nPress Enter to continue, type 'next' to try with another scripture, or type 'quit' to finish: ");
            userChoice = Console.ReadLine().Trim();


            switch (userChoice.ToLower())
            {
                case "quit":
                    Console.WriteLine("Shutting down program, goodbye");
                    programStatus = false;
                    break;

                case "next":
                    int currentIndex = scriptures.IndexOf(currentScripture);
                    int nextIndex = (currentIndex + 1) % scriptures.Count;
                    currentScripture = scriptures[nextIndex];
                    break;

                case "":
                    currentScripture.HideWords();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (programStatus)
            {
                currentScripture.Display();

                if (currentScripture.AreWordsHidden())
                {
                    Console.WriteLine("\n*** All words are hidden now. ***");
                }
            }
        }
    }
}

    
        

        

            
        