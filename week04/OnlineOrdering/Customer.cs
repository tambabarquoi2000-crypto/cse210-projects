public class Customer
{
    private string _name;
    private Address _address;
    private bool _isInUSA;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _isInUSA = address.IsInUSA();
    }


    public bool IsInUSA()
    {
        return _isInUSA;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public Address Address()
    {
        return _address;
    }

    
    
}