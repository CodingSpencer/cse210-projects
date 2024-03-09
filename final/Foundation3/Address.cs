public class Address {

    string _address;

    public Address(string street, string city, string state, string country) {
        _address = $"{street}, {city}, {state}, {country}";
    }

    public string getAddress() {
        return _address;
    }


}