using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUS()
    {
        if (_country == "US" || _country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        string fullAddress = _street + "\n" + _city + ", " + _state + "\n" + _country;
        return fullAddress;
    }
}

//The address contains a string for the street address, the city, state/province, and country.

//The address should have a method that can return whether it is in the USA or not.

//The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)