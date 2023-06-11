using System;

class Program
{
    static void Main(string[] args)
    {
        while (true) {
            Console.WriteLine("Welcome to Improving your Mindfulness!");
            Console.WriteLine("");
            Console.WriteLine("Please Choose an Option Below: ");
            Console.WriteLine("1.Breathing\n2.Reflection\n3.Listing\n4.Visualization\n5.Quit");
            Console.WriteLine("What do you want to do?");
            string response = Console.ReadLine();
            if (response == "1") {
                Breathe breathe = new Breathe();
                Console.Clear();
                breathe.DoActivity();
            }
            else if (response == "2") {
                Reflection reflection = new Reflection();
                Console.Clear();
                reflection.DoActivity();
            }
            else if (response == "3") {
                Listing listing = new Listing();
                Console.Clear();
                listing.DoActivity();
            }
            else if (response == "4") {
                Visualization visualization = new Visualization();
                Console.Clear();
                visualization.DoActivity();
            }
            else {
                Console.Clear();
                break;
            }


        }
            
    }
}