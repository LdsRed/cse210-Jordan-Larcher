namespace Foundation3;

class Receptions : Event
{
    private string _rsvpEmail;
    
    
    public Receptions(string title, string description, string date, int time, Address address, string rsvpEmail) 
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
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

    public override string GetFullDetails()
    {
        var fullDetails = $"Title: {GetTitle()}\n";
        fullDetails += $"Description: {GetDescription()}\n";
        fullDetails += $"Date: {GetDate()}\n";
        fullDetails += $"Time: {GetTime()}\n";
        fullDetails += $"Address: {GetAddress()}\n";
        fullDetails += "Type of Event: Receptions\n";

        return fullDetails;
    }

    public override string GetShortDescription()
    {
        var shortDetails = "Type of Event: Lecture\n";
        shortDetails = $"Title: {GetTitle()}\n";
        shortDetails += $"Date: {GetDate()}\n";

        return shortDetails;
    }
    
  
    private string GetRsvpEmail()
    {
        return this._rsvpEmail;
    }
    
    public void SetRsvEmail(string rsvpEmail)
    {
        this._rsvpEmail = rsvpEmail;
    }
    
}