public class Address
{
    private string _street;
    private string _city;
    private string _region;
    private string _country;

    public Address(string street, string city, string region, string country)
    {
        _street = street;
        _city = city;
        _region = region;
        _country = country;
    }


    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }


    public string GetFullAddress()
    {
        return $"{_street}\n{_city}\n{_region}\n{_country}";
    }

}