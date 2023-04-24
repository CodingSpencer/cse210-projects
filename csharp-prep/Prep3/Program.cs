using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for a number from user
        Console.WriteLine("What is your magic number?");
        // Change userinput to an interger
        string userInput = Console.ReadLine();
        int num = int.Parse(userInput);

        int i = 0;
        int guess;
        do
        {
            Console.WriteLine("What is your guess?");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);

            if (guess > num)
            {
                Console.WriteLine("Higher");
                i++;
            }

            if (guess < num)
            {
                Console.WriteLine("Lower");
                i++;
            }
        }while (guess != num);

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {i} guesses.");
    }
}