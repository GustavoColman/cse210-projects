using System;

class Program
{
    // begins always with the static world on a funcion for now
    static void Main(string[] args)
    {
        //defined variables will receive funcion values to store
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        //display welcome mensage
        Console.WriteLine("Welcome to the progran!");
    }

    static string PromptUserName()
    {
        //define the user name value
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    //define user number value
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        //this funcion saquares (multiply the number by himself)the user number
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    //finally, this funcion show the results
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}