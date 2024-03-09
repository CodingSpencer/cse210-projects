public class Product {

    string _name;

    string _id;

    double _price;

    int _quantity;

    double _total;

    public Product(string name, string id, double price, int quantity) {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
        _total = _price * _quantity;
    }

    public string getName() {
        return _name;
    }

    public string getid() {
        return _id;
    }

    public double getPrice() {
        return _price;
    }

    public int getQuantity() {
        return _quantity;
    }

    public double getTotal() {
        return _total;
    }
}