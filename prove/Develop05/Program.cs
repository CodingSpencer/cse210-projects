using System;

class Program : Goal
{

    public override void Display(int index) {
        Console.WriteLine($" [{Completed()}] {index}. {_goalName} ({_desc}) ");
    }

    public int getPoints(Goal goal) {
        return _points;
    }

    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        

        while (true) {
            Console.Clear();
            Console.WriteLine("Welcome to Eternal Quest Program!");
            Console.WriteLine("");
            Console.WriteLine("Please Choose an Option Below:");
            Console.WriteLine("1.New Goal\n2.List Goals\n3.Save Goal\n4.Load Goal\n5.Add Event\n6.Quit");
            Console.Write("What do you want to do? ");
            string response = Console.ReadLine();
            if (response == "1") {
                Console.Clear();
                Console.WriteLine("The Types of Goals Are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                Console.Write("What type of goal would you like to make? ");
                string type = Console.ReadLine();
                if (type == "1") {
                    Console.Clear();
                    type = "Simple";
                    Simple simple = new Simple("Simple");
                    simple.makeGoal();
                    goals.Add(simple);
                }
                if (type == "2") {
                    Console.Clear();
                    type = "Eternal";
                    Eternal eternal = new Eternal("Eternal");
                    eternal.makeGoal();
                    goals.Add(eternal);
                }
                if (type == "3") {
                    Console.Clear();
                    type = "Checklist";
                    Checklist checklist = new Checklist("Checklist");
                    checklist.makeGoal();
                    goals.Add(checklist);
                }
            }
            else if (response == "2") {
                int i = 1;
                foreach (Goal goal in goals) {
                    goal.Display(i);
                    i++;
                }
                Console.Write("Press Enter When Done: ");
                string input = Console.ReadLine();
                if (input == "") {
            
                }
            }
            else if (response == "3") {
                SaveFile saveFile = new SaveFile();
                saveFile.SaveToFile(goals);
                string input = Console.ReadLine();
                if (input == "") {
            
                }
            }
            else if (response == "4") {
                SaveFile saveFile = new SaveFile();
                saveFile.ReadFromFile();
                string input = Console.ReadLine();
                if (input == "") {
            
                }
            }
            else if (response == "5") {
                Console.Clear();
                int i = 1;
                foreach (Goal goal in goals) {
                    goal.DisplayName(i);
                    i++;
                }
                Console.WriteLine("Which goal did you accomplish? ");
                int finish = int.Parse(Console.ReadLine());
                goals[finish -= 1].makeComplete();
                Score score = new Score();
                Goal newGoals = goals[finish];
                Console.WriteLine($"Congrats! You have earned {score.getPoints(newGoals)} points!\n\n");
                Console.WriteLine($"Your score is: {score.setScore(score.getPoints(newGoals))}");
                string input = Console.ReadLine();
                if (input == "") {
            
                }
            }
            else {
                Console.Clear();
                break;
            }
            }
    }
}