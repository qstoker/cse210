public class Address
{
    string _street;
    string _city;
    string _state;
    string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    public bool InUnitedStates()
    {
        if (
            _country == "United States"
            || _country == "United States of America"
            || _country == "America"
            || _country == "U.S."
            || _country == "US"
            || _country == "U.S.A."
            || _country == "USA"
        )
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
