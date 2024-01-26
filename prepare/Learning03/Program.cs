using System;

class Program
// this is the main class where the program run
{

    //and this is our main method
    static void Main(string[] args)
    {
        // here are the atributes who call the fraction scrypt 
        //and show the results

        //this code is equivalent of print (f"{variable1},{variable2}") on python

        //the variable f1 is declare don the same line where we
        //call the 
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}