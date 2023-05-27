public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer() { } // Constructor

    public string CustomerName // Property
    {
        get
        {
            return _customerName;
        }
    }

    public void SetCustomer(string custname, string street, string city, string state, string country)
    {
        _customerName = custname;
        _address = new Address(street, city, state, country);
    }

    public bool InUS()
    {
        return _address.InUS();
    }

    public string Address
    {
        get
        {
            return _address.GetAddress();
        }
    }
}