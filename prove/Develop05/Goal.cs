public abstract class Goal {

    protected int _points;

    protected string _goalName;

    protected string _desc;

    protected int _score;

    protected bool _isCompleted = false;


    public Goal(){

    }

    public abstract void Display(int index);


    public string Completed() {
        if (_isCompleted == true) {
            return "X";
        }
        else {
            return " ";
        }
    }

    public virtual void makeGoal() {
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        _desc = Console.ReadLine();
        Console.WriteLine("How many points are associated with the goal?");
        _points = int.Parse(Console.ReadLine());
    }
}