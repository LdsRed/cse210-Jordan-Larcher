namespace Foundation3;

class Lecture : Event
{

    private string _speaker;
    private int _capacity;


    public Lecture(string title, string description, string date, int time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string GetFullDetails()
    {
        var fullDetails = $"Title: {GetTitle()}\n";
        fullDetails += $"Description: {GetDescription()}\n";
        fullDetails += $"Date: {GetDate()}\n";
        fullDetails += $"Time: {GetTime()}\n";
        fullDetails += $"Address: {GetAddress()}\n";
        fullDetails += "Type of Event: Lecture\n";
        fullDetails += $"Speaker: {GetNameSpeaker()}\n";
        fullDetails += $"Capacity: {GetCapacity()}\n";

        return fullDetails;
    }

    public override string GetShortDescription()
    {
        var shortDetails = "Type of Event: Lecture\n";
        shortDetails = $"Title: {GetTitle()}\n";
        shortDetails += $"Date: {GetDate()}\n";

        return shortDetails;
    }

    public override string GetStandardDetails()
    {
        var simpleDetails = $"Title: {GetTitle()}\n";
        simpleDetails += $"Description: {GetDescription()}\n";
        simpleDetails += $"Date: {GetDate()}\n";
        simpleDetails += $"Time: {GetTime()}\n";
        simpleDetails += $"Address: {GetAddress()}\n";

        return simpleDetails;
    }

    private string GetNameSpeaker()
    {
        return this._speaker;
    }
    
    public void SetNameSpeaker(string speaker)
    {
        this._speaker = speaker;
    }

    private int GetCapacity()
    {
        return this._capacity;
    }
    public void SetCapacity(int capacity)
    {
        this._capacity = capacity;
    }

}