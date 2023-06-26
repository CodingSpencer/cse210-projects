public abstract class Goal {

    public string _type;

    public int _points;

    protected string _goalName;

    protected string _desc;

    protected int _score;

    protected bool _isCompleted = false;


    public Goal(){

    }

    public abstract void Display(int index);

    public virtual void DisplayName(int index) {
        Console.WriteLine($"{index}. {_goalName}");
    }

    public virtual void makeComplete() {
        _isCompleted = true;
    }

    


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