using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 48, 17,18);
        Scripture scripture = new Scripture("17 Yea, verily, verily I say unto you, if all men had been, and were, and ever would be, like unto Moroni, behold, the very powers of hell would have been shaken forever; \nyea, the devil would never have power over the hearts of the children of men.\n18 Behold, he was a man like unto aAmmon, the son of Mosiah, yea, and even the other sons of Mosiah, yea, and also Alma and his sons, for they were all men of God.");
        reference.DisplayMultiple();
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