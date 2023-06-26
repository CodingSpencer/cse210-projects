public class Checklist : Goal {
    
    public int _times;

    public int _bonusPoints;

    public int _progress = 0;

    public Checklist(string type) {
       _type = type;
        _progress++;
    }


    public override void Display(int index) {
        Console.WriteLine($" [{Completed()}] {index}. {_goalName} ({_desc}) -- Currently Completed {_progress}/{_times}");
    }

    public virtual void makeGoal() {
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