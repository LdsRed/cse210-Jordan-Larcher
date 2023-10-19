public class Reference
{

    private string _book;
    private string _chapter;
    private string _singleVerse;

    public Reference()
    {
        
    }

    public Reference(string book)
    {
        this._book = book;
    }

    public Reference(string book, string chapter)
    {
        this._book = book;
        this._chapter = chapter;
    }

    public Reference(string book, string chapter, string singleVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._singleVerse = singleVerse;
    }


    
    
}