public class Word
{
    private string _text;
    private bool _hidden;
    

    public Word(string text)
    {
        this._text= text;
        this._hidden = false;
    }

    public string GetText()
    {
        return _text;
    }

    public bool GetHidden()
    {
        return _hidden;
    }

    public void SetHidden(bool value)
    {
        this._hidden = value;
    }
}