using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("hello, my name is Colman, ");

        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"So...Your name is {last}, {first} {last}.right?");
    }
}
