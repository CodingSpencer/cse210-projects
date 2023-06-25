public class Checklist : Goal {

    public Checklist() {

    }


    public override void Display(int index) {
        Console.WriteLine($" [{Completed()}] {index}. {_goalName} ({_desc}) ");
    }

}