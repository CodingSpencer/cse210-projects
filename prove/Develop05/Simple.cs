public class Simple : Goal {



    public Simple() {

    }


    public override void Display(int index) {
        Console.WriteLine($" [{Completed()}] {index}. {_goalName} ({_desc}) ");
    }


}