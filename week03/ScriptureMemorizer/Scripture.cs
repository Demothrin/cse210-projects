public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount += 1;
            }

        }
    }
    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(tempWord => tempWord.GetDisplayText()));
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(tempWord => tempWord.IsHidden());
    }
}