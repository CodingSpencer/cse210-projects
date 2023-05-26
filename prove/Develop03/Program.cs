using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Captain America is the best avenger ever born.");
        scripture.DisplayScripture();
        while (true){
            Console.ReadLine();
            scripture.hideScripture();
            scripture.DisplayScripture();
        }
    }
}