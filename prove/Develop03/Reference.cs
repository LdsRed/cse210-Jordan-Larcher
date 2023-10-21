public class Reference
{

    private string _reference;
    private int _startVerse;
    private int _endVerse;

    public Reference()
    {
        
    }

    public Reference(string reference)
    {
        this._reference = reference;
        var referenceParts = reference.Split(':');
        _startVerse = int.Parse(referenceParts[1].Split('-')[0]);
        if(referenceParts[1].Contains('-'))
        {
            _endVerse = int.Parse(referenceParts[1].Split('-')[1]);
        }
        else
        {
            _endVerse = _startVerse;
        }

    }


    public string GetReference()
    {
        return this._reference;
    }

    public int GetStartVerse()
    {
        return this._startVerse;
    }

    public int GetEndVerse()
    {
        return this._endVerse;
    }



    public string DisplayReference()
    {
        return $"{GetReference()}:{GetStartVerse()} - {GetEndVerse()}";
    }
}