public class Word
{
    private string _text;
    private bool _hidden;
    

    public Word(string text)
    {
        SetText(text);
        SetHidden(false);
    }

    public string GetText()
    {
        if(GetHidden())
        {
            return new string('_', _text.Length);
        }
        else
        {
            return this._text;
        }
    }

    public void SetText(string text)
    {
        this._text = text;
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