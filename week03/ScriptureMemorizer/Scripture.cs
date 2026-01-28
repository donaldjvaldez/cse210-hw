public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(" "))
        {_words.Add(new Word(word));            
        }
    }
    public void HideRandomWords(int count) {
        Random random = new Random();
        int wordsLeft = _words.Count(w => !w.IsHidden());

        int toHide = Math.Min(count, wordsLeft);

        int hiddenCount = 0;
        while (hiddenCount < toHide) {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {_words[index].Hide();
            hiddenCount++;                
            }
        }
        if (_words.Count(w => !w.IsHidden()) == 1)
        {_words.First(w => !w.IsHidden()).Hide();            
        }
        // for (int i = 0; i < count; i++) {
        //     int index = random.Next(_words.Count);
        //     _words[index].Hide();
        // }
    }
    public string GetDisplayText() {
        string result = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words) {
            result += word.GetDisplayText() + " ";
        }
        return result.Trim();
    }
    public bool IsCompletelyHidden() {
        return _words.All(w => w.IsHidden());
    }
}