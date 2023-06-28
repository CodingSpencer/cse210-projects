using System;

class Program
{

    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        int _score = 0;

        string _level;
        

        while (true) {
            if (_score > 500) {
                _level = "Expert";
            }
            else if (_score > 350) {
                _level = "Intermediate";
            }
            else if (_score > 100) {
                _level = "Beginner";
            }
            else {
                _level = "Novice";
            }
            Console.Clear();
            Console.WriteLine("Welcome to Eternal Quest Program!");
            Console.WriteLine($"Score: {_score} | Level: {_level}");
            Console.WriteLine("Please Choose an Option Below:");
            Console.WriteLine("1.New Goal\n2.List Goals\n3.Save Goal\n4.Load Goal\n5.Complete Event\n6.Quit");
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
                Console.Write("Press Enter When Done: ");
                string input = Console.ReadLine();
                if (input == "") {
            
                }
            }
            else if (response == "4") {
                SaveFile saveFile = new SaveFile();
                saveFile.ReadFromFile(goals);
                Console.Write("Press Enter When Done: ");
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
                int finish = int.Parse(Console.ReadLine()) - 1;

                if (goals[finish].returnComplete() == false){
                    if (goals[finish]._isPositive == true) {
                        _score += goals[finish].returnPoints();
                    }
                    else {
                        _score -= goals[finish].returnPoints();
                    }
                    goals[finish].makeComplete();
                    if (goals[finish]._isPositive == true) {
                        _score += goals[finish].getScore();
                        Console.WriteLine($"Congrats! You have earned {goals[finish]._points} points!\n\n");

                    }
                    else {
                        _score -= goals[finish].getScore();
                        Console.WriteLine($"Sorry! You have lost {goals[finish]._points} points!\n\n");

                    }

                }
                // Score score = new Score();
                // // Goal newGoals = goals[finish];
                Console.WriteLine($"Congrats! You have earned {goals[finish]._points} points!\n\n");
                Console.WriteLine($"Your score is: {_score}");
                Console.Write("Press Enter When Done: ");
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