using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        int last_digit = percentage % 10;
        
        string symbol = "";
        
        if (last_digit > 7)
        {
            symbol = "+";
        }
        if (last_digit < 3)
        {
            symbol = "-";
        }

        string grade = "";

        if (percentage > 90)
        {
            grade = "A";
        }
        else if (percentage > 80)
        {
            grade = "B";
        }
        else if (percentage > 70)
        {
            grade = "C";
        }
        else if (percentage > 60)
        {
            grade = "D";
        }
        else if (percentage < 60)
        {
            grade = "F";
        }

        if (grade == "A" || grade == "F")
            {
                Console.WriteLine($"Your grade is an {grade}.");
            }
        else
        {
            Console.WriteLine($"Your grade is an {grade}{symbol}.");
        }

        if (percentage > 70)
        {
            Console.Write("You passed!");
        }
        else
        {
            Console.Write("You didn't pass. Good luck next time!");
        }


    }
}