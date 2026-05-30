public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    private bool _isInUSA;



    public Address(string sAddress, string city, string state, string country)
    {
        _streetAddress = sAddress;
        _city = city;
        _state = state;
        _country = country;
        
        if(country == "USA" || country == "United States of America")
        {
            _isInUSA = true;
        }
    }

    public void setStAddress(string address)
    {
        _streetAddress = address;
    }
    public void setCity(string city)
    {
        _city = city;
    }
    public void setState(string state)
    {
        _state = state;
    }
    public void setCountry(string country)
    {
        _country = country;
        if(_country == "USA" || _country == "United States of America")
        {
            _isInUSA = true;
        }
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}\n{_state}, {_country}";
    }

    public bool IsInUSA()
    {
        return _isInUSA;
    }
}