public abstract class Goal {

    public string _type;

    public bool _isPositive;

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

    public bool returnComplete() {
        return _isCompleted;
    }

    public int returnPoints(){
        return _points;
    }


    public string Completed() {
        if (_isCompleted == true) {
            return "X";
        }
        else {
            return " ";
        }
    }

    public virtual int getScore() {
        return 0;
    }

    public string positive() {
        if (_isPositive == true) {
            return "+";
        }
        else {
            return "-";
        }
    }
    

    public virtual void makeGoal() {
        Console.WriteLine("Will you + or - points when this is completed?");
        if (Console.ReadLine() == "+") {
            _isPositive = true;
        }
        else {
            _isPositive = false;
        }
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        _desc = Console.ReadLine();
        Console.WriteLine("How many points are associated with the goal?");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual void loadGoal(string name, string desc, string points, string complete, string positive) {
        _goalName = name;
        _desc = desc;
        _points = int.Parse(points);
        _isCompleted = bool.Parse(complete);
        _isPositive = bool.Parse(positive);
    }

    public virtual string getSaveFormat() {
        return $"{_type}:{_goalName}, {_desc}, {_points}, {_isCompleted}, {_isPositive}";
    }
}