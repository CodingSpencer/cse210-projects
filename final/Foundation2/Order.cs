public class Order {
    string _customer;

    string _shipping;

    string _packing;

    List<Product> _products = new List<Product>();

    public Order(string customer, string shipping, string packing) {
        _customer = customer;
        _shipping = shipping;
        _packing = packing;
    }

    public void addProduct(Product product) {
        _products.Add(product);
    }

    public string getCustomer() {
        return _customer;
    }

    public string getShipping() {
        return _shipping;
    }

    public string getPacking() {
        return _packing;
    }

    

    public double getTotal() {
        return _products[0].getTotal() + _products[1].getTotal() + _products[2].getTotal();
    }

    public void DisplayProducts() {
        foreach (Product product in _products) {
            Console.WriteLine($"Product: {product.getName()}, ${product.getPrice()}, {product.getQuantity()}");
        }
    }

    

}