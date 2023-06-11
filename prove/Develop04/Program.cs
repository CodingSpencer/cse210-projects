using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        while (true) {
            Console.WriteLine("Welcome to Improving your Mindfulness!");
            Console.WriteLine("Please Choose an Option Below: ");
            Console.WriteLine("1.Breathing\n2.Reflection\n3.Listing\n4.Quit");
            Console.WriteLine("What do you want to do?");
            string response = Console.ReadLine();
            if (response == "1") {
                Breathe breathe = new Breathe();
                breathe.DoActivity();
            }
            else if (response == "2") {
                
            }
            else if (response == "3") {

            }
            else {
                break;
            }


        }
            
    }
}