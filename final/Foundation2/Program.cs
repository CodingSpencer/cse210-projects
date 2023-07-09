using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Order: ");

        Address a1 = new Address("1 South 1 East", "Rexburg", "Idaho", "US");
        Customer c1 = new Customer("Steve Rogers", a1);
        Console.WriteLine($"Address: {a1.getAddress()}");

        
        Order o1 = new Order(c1.getName(), "555-555", "888-888");
        Console.WriteLine($"Customer: {o1.getCustomer()}\nShipping: {o1.getShipping()}\nPacking: {o1.getPacking()}");

        o1.addProduct(new Product("Milk", "1234", 11.80, 6));
        o1.addProduct(new Product("Cheese", "1111", 7.60, 3));
        o1.addProduct(new Product("Eggs", "2333", 4.90, 2));
        o1.DisplayProducts();
        c1.makeShipping();
        Console.WriteLine($"Total Price: ${o1.getTotal()}");
        Console.WriteLine($"Shipping: ${c1.getShipping()}");
        Console.WriteLine($"Total Price: ${o1.getTotal()+c1.getShipping()}");



    }
}