using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 48, 17);
        Scripture scripture = new Scripture("Yea, verily, verily I say unto you, if all men had been, and were, and ever would be, like unto Moroni, behold, the very powers of hell would have been shaken forever; yea, the devil would never have power over the hearts of the children of men.");
        reference.Display();
        scripture.DisplayScripture();
        while (true){
            string input = Console.ReadLine();
            if (scripture.Num.Count() == 0){
                Console.WriteLine("You completed memorizing the scripture!");
                break;
            }
            else if (input == ""){
                scripture.hideScripture();
                reference.Display();
                scripture.DisplayScripture();
            }
            else if (input == "quit"){
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }
}