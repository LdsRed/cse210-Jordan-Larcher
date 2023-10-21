public class Scripture
{

    private string _text;
    private Reference _reference;

    private List<Word> words = new();


    public Scripture()
    {

    }

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._text = text;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }


    public Reference GetReference()
    {
        return this._reference;
    }

    public string GetText()
    {
        return this._text;
    }



    
    public void HideFromRandomWord()
    {
        List<Word> hiddenWords = words.Where(word => word.GetHidden()).ToList();
        List<Word> nonHiddenWords = words.Where(word => !word.GetHidden()).ToList();
    
        if (nonHiddenWords.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(nonHiddenWords.Count);
            nonHiddenWords[index].SetHidden(true);
        }

    }
    
    public bool AllWordsHidden()
    {
        return words.All(word => word.GetHidden());
    }


    public string GetHiddenScripture()
    {
        List<string> textHidden = new();
        foreach(Word text in words)
        {   
            textHidden.Add(text.GetText());
        }

        return string.Join(" ", textHidden);
    }

    public void ScriptureMemorizer()
    {
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

    

    // public void Menu()
    // {
    //     string selection = "";
    //     while (selection != "4")
    //     {


    //         Console.WriteLine("Please selec one of the following choices: ");
    //         Console.WriteLine("1. Start memorizing \n2. Show available scriptures \n3. Add a new Scripture to memorize \n4. Quit");
    //         Console.WriteLine("What whould you like to do? ");
    //         selection = Console.ReadLine();

    //         switch (selection)
    //         {
    //             case "1":
    //                 ScriptureMemorizer();
    //                 break;
    //             case "2":
    //                 AvailableScriptures();
    //                 break;
    //             case "3":
    //                 AddNewScripture();
    //                 break;
    //             case "4":
    //                 break;

    //     }

    // }

}