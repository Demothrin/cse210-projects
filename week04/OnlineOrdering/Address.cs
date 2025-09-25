public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isInAmerica;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUsa()
    {

    }

    public string DisplayAddress()
    {
        
    }
}