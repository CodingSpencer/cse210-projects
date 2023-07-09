public class Customer {

    string _name;

    Address _address;

    int _shipping;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public void makeShipping() {
        if (_address.getCountry() == true) {
            _shipping = 5;
        }
        else {
            _shipping = 35;
        }
    }

    public int getShipping() {
        return _shipping;
    }

    public string getName() {
        return _name;
    }

    public Address getAddress() {
        return _address;
    }

}