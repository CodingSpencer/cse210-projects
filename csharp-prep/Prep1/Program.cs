using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for user's first name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        // Ask for user's last name
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // Spacer
        Console.WriteLine("");

        // Print name in James Bond format
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}