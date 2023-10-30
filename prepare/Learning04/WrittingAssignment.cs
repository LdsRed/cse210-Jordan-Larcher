public class WrittingAssignment : Assignment
{

    private string _title;

    public WrittingAssignment(){}
    public WrittingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        this._title = title;
    }


    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}