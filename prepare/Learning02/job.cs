using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
Job job1 =new Job();
Job1._jobTitle ="software developer";
job1._company ="meta";
job1._startYear ="2024";
job1._endYear ="2024";

