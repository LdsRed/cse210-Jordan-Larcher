using System.Dynamic;

class Comment
{

    private string _name;
    private string _textComment;

    public Comment(string name, string textComment)
    {
        SetName(name);
        SetComment(textComment);
    }

    public string GetComment()
    {
        return this._textComment;
    }
    
    public string GetName()
    {
        return this._name;
    }

    public void SetComment(string comment)
    {
        this._textComment = comment;
    }

    public void SetName(string name)
    {
        this._name = name;
    }
}