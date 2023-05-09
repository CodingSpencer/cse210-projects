using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt prompt = new Prompt();
        string question = prompt.GetRandomPrompt();
        Console.WriteLine($"{question}");
        string entry = Console.ReadLine();
    }
}