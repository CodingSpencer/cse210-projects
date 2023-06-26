public class Simple : Goal {

    public Simple(string type) {
        _type = type;
    }


    public override void Display(int index) {
        Console.WriteLine($" [{Completed()}] {index}. {_goalName} ({_desc}) ");
    }


}