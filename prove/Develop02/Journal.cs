using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string date, string prompt)
    {
        Entry newEntry = new Entry
        {
            _date = date,
            _prompt = prompt
        };

        Prompts prompts = new Prompts();
        string randomPrompt = prompts.RandomPrompt();
        Console.WriteLine(randomPrompt);

        string userEntry = Console.ReadLine();
        newEntry._entryText = userEntry;
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        Console.WriteLine("All Entries:\n");
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date}\nPrompt: {entry._prompt}\nEntry Text: {entry._entryText}");
            }
        }

        Console.WriteLine("Entries saved to file: " + file);
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        for (int i = 0; i < lines.Length; i += 3)
        {
            if (i + 2 < lines.Length)
            {
                string date = GetValueFromLine(lines[i]);
                string prompt = GetValueFromLine(lines[i + 1]);
                string entryText = GetValueFromLine(lines[i + 2]);

                Entry loadedEntry = new Entry
                {
                    _date = date,
                    _prompt = prompt,
                    _entryText = entryText
                };

                _entries.Add(loadedEntry);
            }
        }

        Console.WriteLine("Entries loaded from file: " + file);
    }

    private string GetValueFromLine(string line)
    {
        string[] parts = line.Split(":");
        if (parts.Length > 1)
        {
            return parts[1].Trim();
        }
        return string.Empty;
    }

}