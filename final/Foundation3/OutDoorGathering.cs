namespace Foundation3;

class OutDoorGathering : Event
{
    private string _weather;
    public OutDoorGathering(string title, string description, string date, int time, Address address, string weather) 
        : base(title, description, date, time, address)
    {
        SetWeather(weather);
    }

    public override string GetStandardDetails()
    {
        var simpleDetails = $"Title: {GetTitle()}\n";
        simpleDetails += $"Description: {GetDescription()}\n";
        simpleDetails += $"Date: {GetDate()}\n";
        simpleDetails += $"Time: {GetTime()}\n";
        simpleDetails += $"Address: {GetAddress().GetFullAddress()}\n";

        return simpleDetails;
    }

    public override string GetFullDetails()
    {
        var fullDetails = "Type of Event: Outdoor Gathering\n";
        fullDetails += $"Title: {GetTitle()}\n";
        fullDetails += $"Description: {GetDescription()}\n";
        fullDetails += $"Date: {GetDate()}\n";
        fullDetails += $"Time: {GetTime()}\n";
        fullDetails += $"Address: {GetAddress().GetFullAddress()}\n";
        fullDetails += $"Weather: {GetWeather()}\n";
        

        return fullDetails;
    }

    public override string GetShortDescription()
    {
        var shortDetails = "Type of Event: Outdoor Gathering\n";
        shortDetails += $"Title: {GetTitle()}\n";
        shortDetails += $"Date: {GetDate()}\n";

        return shortDetails;
    }
    
    
    private void SetWeather(string weather)
    {
        this._weather = weather;
    }
    
    private string GetWeather()
    {
        return this._weather;
    }
    
    
    
}