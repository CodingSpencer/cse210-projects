public class Eternal : Goal {
    
    public Eternal() {

    }


    public override void Display(int index) {
        Console.WriteLine($" [{Completed()}] {index}. {_goalName} ({_desc}) ");
    }
}