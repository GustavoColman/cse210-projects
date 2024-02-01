using System;

//this is the base file who runs the program

//the class program is the main class of the project
class Program
{
    // the main method is the starter method of the program
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("gustavo colman", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        //NOTICE that A1 is a variable defined whem is called on line 12
        // so a2 and a3 will have the same porpose on store this
        //new sub classes

        // Now create the derived class assignments
        //this mathod pass the values to the assignments scrupts,ex :
        /// public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        //: base(studentName, topic)
        MathAssignment a2 = new MathAssignment("silvio santos", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

//we are passing the valors name and project name to the writing assignment.cs here
//so, this is a setter
        WritingAssignment a3 = new WritingAssignment("jhon dark souls 2", "american History", "The Causes of the donnuts war");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
    //basically, we define all this structure here on the program file and
    //the other scripts just keep the other classes with their own
    //atributes, we just pass the values here on the main file and
    //retrive the methods calling them here
}