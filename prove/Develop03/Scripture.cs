public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(string reference, string scripture)
    {
        string[] words = scripture.Split(" ");
        _reference = new Reference(reference);

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.Write(_reference.GetReference());
        foreach (Word word in _words)
        {
            if (word.GetHidden() == true)
            {
                foreach (char c in word.GetWord())
                {
                    Console.Write("_");
                }
                Console.Write(" ");
            }
            else if (word.GetHidden() == false)
            {
                Console.Write($"{word.GetWord()} ");
            }
        }
        Console.WriteLine("\n");
    }

    public int PEnd()
    {
        return _words.Count();
    }

    public void HideRandomWords(int numberOFWordsToHide = 3)
    {
        int hiddenCount = 0;
        List<int> unhiddenIndexes = _words.Select((word, index) => new { word, index })
                                        .Where(item => !item.word.GetHidden())
                                        .Select(item => item.index)
                                        .ToList();

        while (hiddenCount < numberOfWordsToHide && unhiddenIndexes.Count > 0)
        {
            int randomIndexIndex = _random.Next(unhiddenIndexes.Count);
            int randomIndex = unhiddenIndexes[randomIndexIndex];

            _words[randomIndex].HideWord();
            unhiddenIndexes.RemoveAt(randomIndexIndex);
            hiddenCount++;
        }
    }

    public int AddInt()
    {
        foreach (Word w in _words)
        {
            if (w.GetHidden() == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        return 0;
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.GetHidden());
    }
}
