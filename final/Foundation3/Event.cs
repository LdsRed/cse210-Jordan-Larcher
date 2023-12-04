namespace Foundation3;

abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private int _time;
    private Address _address;


    protected Event(string title, string description, string date, int time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public abstract string GetStandardDetails();

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();

    protected string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    protected string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    protected string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    protected int GetTime()
    {
        return _time;
    }

    public void SetTime(int time)
    {
        _time = time;
    }

    protected Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }
    
}