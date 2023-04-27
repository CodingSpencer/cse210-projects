

using System;

class Program
{
    static void Main(string[] args)
    {
        static void welcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userInput = Console.ReadLine();
            int num = int.Parse(userInput);
            return num;
        }

        static string User_Name()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"{name} Hello There!");
            return name;
        }

        static int SquareNumber(int num)
        {
            int squar_num = num*num;
            return squar_num;

        }

        static void DisplayResult(string name, int squar_num)
        {
            Console.WriteLine($"{name}, your favorite number squared is {squar_num}");
        }

        welcome();
        string name = User_Name();
        int num = PromptUserNumber();
        int squar_num = SquareNumber(num);
        DisplayResult(name, squar_num);

        


    }
}