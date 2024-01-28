using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        bool programstatus = true ;
        string userchoice;

        while ( programstatus )
        {
            Console.WriteLine("this is a test");
            Console.WriteLine("choose a option, 1 or 2 or type quit");
            userchoice = Console.ReadLine();

            if (userchoice == "1")
            {
                Console.WriteLine("this is ligma");
            }
            if (userchoice == "2")
            {
                Console.WriteLine("this is sugma");
            }
            if (userchoice == "quit")
            {
                Console.WriteLine("shutting down program, goodbye");
                programstatus = false;
            }
        }
    }
    
        
}
        

            
        