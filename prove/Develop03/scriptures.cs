public class Scripture
{
    private Reference _reference;
    private List<Word> _excerpt;
    private string[] tempString;
    private static Random randomNum = new Random();
    private int numb;

    public Scripture(string verse, Reference reference)
    {
        this._reference = reference;
        this._excerpt = new List<Word>();
        tempString = verse.Split(" ");
        foreach (string word in tempString)
        {
            this._excerpt.Add(new Word(word));
        }
    }

    public void Display()
    {

        _reference.Display();
        foreach (Word value in _excerpt)
        {
            value.Display();
        }
    }

    public void HideWords()
    {
        foreach (Word value in _excerpt)
        {
            if (!value.GetVisibility())
            {
                continue;
            }
            numb = randomNum.Next(0, 2);
            if (numb == 1)
            {
                value.SetVisibility(false);
            }
        }
    }

    public bool AreWordsHidden()
    {
        return _excerpt.TrueForAll(value => !value.GetVisibility());
    }
}

