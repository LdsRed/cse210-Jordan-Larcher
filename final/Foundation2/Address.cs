class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }



    public string GetFullAddress()
    {
        return $"Street: {_streetAddress} \nCity: {_city} \nState {_state} \nCountry: {_country}.";
    }

    public bool CheckCountry()
    {
       return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
    
}