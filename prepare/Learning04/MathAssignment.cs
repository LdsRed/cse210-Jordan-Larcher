public class MathAssignment : Assignment
{

    private string _textbookSection;
    private string _problems;
    public MathAssignment(){}

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName,topic)
    {

        this._textbookSection = textbookSection;
        this._problems = problems;
    }


    public string GetTextBookSection()
    {
        return _textbookSection;
    }

    public void SetTextBookSection(string bookSection)
    {
        this._textbookSection = bookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        this._problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} {_problems}";
    }


}