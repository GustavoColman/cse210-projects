public class WritingAssignment : Assignment
{
    private string _title;

    // Notice the syntax here that the WritingAssignment constructor has 3 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // Here we set any variables specific to the WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    //here we will receive the values of name and project name
    //from the main program.cs from LINE 25
    //WritingAssignment a3 = new WritingAssignment("jhon dark souls 2", "american History", "The Causes of the donnuts war");
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();
//this print the work title of jhon dark souls 2 and his name 
        return $"{_title} by {studentName}";
    }
}