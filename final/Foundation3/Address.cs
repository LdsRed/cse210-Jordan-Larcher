namespace Foundation3;

class Address
{

    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _postalCode;

    public Address(string street, string city, string state, string country, string postalCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _postalCode = postalCode;
    }
    

    
    
    public string GetFullAddress()
    {
        var fullAddress = $"Street: {GetStreet()}\n";
        fullAddress += $"City: {GetCity()}\n";
        fullAddress += $"State: {GetState()}\n";
        fullAddress += $"Country: {GetCountry()}\n";
        fullAddress += $"Postal Code: {GetPostalCode()}";

        return fullAddress;
    }


    private string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    private string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    private string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    private string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    private string GetPostalCode()
    {
        return _postalCode;
    }

    public void SetPostalCode(string postalCode)
    {
        _postalCode = postalCode;
    }
    
}