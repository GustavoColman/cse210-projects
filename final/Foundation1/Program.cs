using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("How to C#", "Jane Doe", 300);
        video1.AddComment("John Smith", "Great video!");
        video1.AddComment("Alice Johnson", "Very helpful, thanks!");
        video1.DisplayVideoInfo();
    }
}