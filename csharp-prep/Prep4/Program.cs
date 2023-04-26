using System;

class Program
{
    static void Main(string[] args)
    {
        // Begin a list to hold numbers
        List<int> numbers = new List<int>();
        // Create add_on variable
        int add_on;
        // Print user instructions
        Console.WriteLine("Please enter some numbers onto a list and enter 0 when complete.");
        
        // Create a loop until 0 is entered as a number
        do
        {
            // Ask user to enter a number
            Console.Write("Enter a number: ");
            // Receive userInput and change it to an interger
            string userInput = Console.ReadLine();
            add_on = int.Parse(userInput);
            // Add userInput to numbers list
            numbers.Add(add_on);
        }while (add_on != 0);
        
        // Figure and set variables for max, sum, and average
        int sum = numbers.Sum();
        int max = numbers.Max();
        int average = sum / (numbers.Count());

        // Print sum, average, and max
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {max}");

    }
}