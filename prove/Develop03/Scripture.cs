public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<Word> _visWords;
    private int _lastPoint = 1;
    

    // ------------------------

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;

        foreach (string word in scripture.Split(" "))
        {
            _words.Add(new Word(word));
        }
        
        _visWords = new List<Word>(_words);
    }

    // ------------------------------

    public void PrintFullScripture()
    {
        Console.WriteLine(_reference.GetReferenceString());
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetShownContent()} ");
        }
    }

    public void Make3Invisible()
    {
        Random random = new Random();
        
        for (int i = 0; i < 3; i++)
        {
            if (_visWords.Count != 0) {
                int randIndex = random.Next(_visWords.Count);
                _visWords[randIndex].MakeNotVisible();
                _visWords.RemoveAt(randIndex);
            }
        }
    }
    public bool AreAllInvisible()
    {   
        bool yes = true;
        if (_visWords.Count <= 0)
        {
            if (_lastPoint == 0)
            {
                yes = false;
            }
            _lastPoint = 0;
        }
        
        return yes;
    }
}