public class Address {

    bool inUS = true;

    string _address;

    public Address(string street, string city, string state, string country) {
        _address = $"{street}, {city}, {state}, {country}";
        if (country != "US"){
            inUS = false;
        }
    }

    public bool getCountry() {
        return inUS;
    }

    public string getAddress() {
        return _address;
    }


}