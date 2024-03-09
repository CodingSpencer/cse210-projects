public class Simple : Goal {

    public Simple(string type) {
        _type = type;
    }


    public override void Display(int index) {
        Console.WriteLine($" [{Completed()}] {index}. {positive()} {_goalName} ({_desc}) ");
    }


}