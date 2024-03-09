public class Checklist : Goal {
    
    int _addScore;
    
    public int _times;

    public int _bonusPoints;

    public int _progress = 0;

    public Checklist(string type) {
       _type = type;
    }

    public override int getScore() {
        return _addScore;
    }

    public void addBonus() {
        _addScore = _bonusPoints;
    }


    public override void makeComplete()
    {
        _progress++;
        if (_progress < _times) {
            _isCompleted = false;
        }
        if (_progress == _times) {
            _isCompleted = true;
            addBonus();
            Console.WriteLine($"Great job completing a checklist goal! You get {_addScore} bonus points.");
        }
        else {
            _isCompleted = true;
        }
    }


    public override void Display(int index) {
        Console.WriteLine($" [{Completed()}] {index}. {positive()} {_goalName} ({_desc}) -- Currently Completed {_progress}/{_times}");
    }

    public override string getSaveFormat()
    {
        return $"{_type}:{_goalName}, {_desc}, {_points}, {_bonusPoints}, {_isCompleted}, {_times}, {_progress}, {_isPositive} ";
    }

    public void loadCheck(string name, string desc, string points, string bonus, string complete, string times, string progress, string positive) {
        _goalName = name;
        _desc = desc;
        _points = int.Parse(points);
        _bonusPoints = int.Parse(bonus);
        _isCompleted = bool.Parse(complete);
        _times = int.Parse(times);
        _progress = int.Parse(progress);
        _isPositive = bool.Parse(positive);

    }

    public override void makeGoal() {
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
        Console.WriteLine("How many times does this goal need to be completed to get the bonus?");
        _times = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points are associated with the checklist?");
        _bonusPoints = int.Parse(Console.ReadLine());
        
    }
}