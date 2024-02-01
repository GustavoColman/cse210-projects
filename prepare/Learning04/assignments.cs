public class Assignment
//the public class assignment is the superclass of the project, all the other classes will 
//inherit his propieties
{
    private string _studentName;
    private string _topic;

//this method defines the previous atributes to be updated
//as the new values this method will receive by the setters values passed on the main
//funcion on program.cs
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}