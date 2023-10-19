public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }


    public Scripture(Reference reference)
    {
        Reference = reference;
    }
    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        List<Word> hiddenWords = Words.Where(word => word.Hidden).ToList();
        List<Word> nonHiddenWords = Words.Where(word => !word.Hidden).ToList();

        if (nonHiddenWords.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(nonHiddenWords.Count);
            nonHiddenWords[index].Hidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.Hidden);
    }
}