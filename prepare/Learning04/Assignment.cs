public class Assignment 
{
    private string _studentName;
    private string _topic;


    public Assignment(){}

    public Assignment(string studentName, string topic)
    {
        this._studentName = studentName;
        this._topic = topic;
    }

    public string GetSummary()
    {
        return  $"{_studentName} - {_topic}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string studentName)
    {
        this._studentName = studentName;
    }


    public string GetTopic()
    {
        return _topic;
    }
    

    public void SetTopic(string topic)
    {
        this._topic = topic;
    }
}