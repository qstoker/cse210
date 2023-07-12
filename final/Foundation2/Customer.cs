public class Customer
{
    string _name;
    Address _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressString()
    {
        return _address.GetAddressString();
    }

    public bool InUnitedStates()
    {
        return _address.InUnitedStates();
    }
}
