using System;
public class Entry
{
    public string _date;
    public string _prompt;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nEntry Text: {_entryText}");
    }
}