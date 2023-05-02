public class Car {

    //instances
    public string brand;
    public int miles;
    public string color;


    //costructor
    public Car(){

    }


    //methods (functions)
    public void move_forward(){
        Console.Write("is running");
    }

    public void displayInfo(){
        Console.Write($"Brand: {brand} Miles: {miles} Color:{color}");
    }
}
