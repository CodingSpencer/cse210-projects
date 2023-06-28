public class Eternal : Goal {

    public Eternal(string type) {
       _type = type;

    }

    public override void makeComplete()
    {
        _isCompleted = false;
    }

    public override void Display(int index) {
        Console.WriteLine($" [{Completed()}] {index}. {positive()} {_goalName} ({_desc}) ");
    }
}