
public class Scripture
{

    
    //Instance variables
    private string _text;
    private Reference _reference;
    private List<Word> _words = new();
 

    public Scripture()
    {

    }

    //Constructor: it will received a Reference object and a string
    //then the string text will be transformed to a List using first the Select query from the LINQ Query Syntax
    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._text = text;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }


    public Reference GetReference()
    {
        return this._reference;
    }

    public string GetText()
    {
        return this._text;
    }



    //Method designed to hide random words
    public void HideFromRandomWord()
    {
        List<Word> hiddenWords = _words.Where(word => word.GetHidden()).ToList();
        List<Word> nonHiddenWords = _words.Where(word => !word.GetHidden()).ToList();
    
        if (nonHiddenWords.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(nonHiddenWords.Count);
            nonHiddenWords[index].SetHidden(true);
        }

    }
    
    
    //This method will allows you to know if all the words are hidden by using the All query from LINQ Query Syntax
    public bool AllWordsHidden()
    {
        return _words.All(word => word.GetHidden());
    }


    public string GetHiddenScripture()
    {
        List<string> textHidden = new();
        foreach(Word text in _words)
        {   
            textHidden.Add(text.GetText());
        }

        return string.Join(" ", textHidden);
    }
    
    
   
    public void ScriptureMemorizer()
    {
        
        Console.WriteLine("A scripture will be displayed to be memorized. Enjoy it!");
        
        
        while(!AllWordsHidden())
        {
            Console.WriteLine($"{_reference.GetReference()}: {GetHiddenScripture()}");
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            string userInput = Console.ReadLine();

            if(userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                HideFromRandomWord();
                Console.Clear();
            }
        }
    }

    

   
}