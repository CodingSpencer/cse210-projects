using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        

        while (true) {
            Console.WriteLine("Welcome to Eternal Quest Program!");
            Console.WriteLine("");
            Console.WriteLine("Please Choose an Option Below: ");
            Console.WriteLine("1.New Goal\n2.List Goals\n3.Save Goal\n4.Load Goal\n5.Add Event\n6.Quit");
            Console.WriteLine("What do you want to do?");
            string response = Console.ReadLine();
            if (response == "1") {
                Console.WriteLine("The Types of Goals Are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                Console.WriteLine("What type of goal would you like to make? ");
                string type = Console.ReadLine();
                if (type == "1") {
                    Simple simple = new Simple();
                    simple.makeGoal();
                    goals.Add(simple);
                }
                if (type == "2") {

                }
                if (type == "3") {
                    
                }
            }
            else if (response == "2") {
                int i = 1;
                foreach (Goal goal in goals) {
                    goal.Display(i);
                    i++;
                }
            }
            else if (response == "3") {
                
            }
            else if (response == "4") {
                
            }
            else if (response == "5") {
                
            }
            else {
                Console.Clear();
                break;
            }
            }
    }
}