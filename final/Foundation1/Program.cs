using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Video v = new Video("Video 1","Tony Stark",454);
        v.Display();

        Comments c = new Comments("Steve Rogers","What a great video!");
        v.addComment(c.format());

        Comments c1 = new Comments("Natasha Rominoff","This was so helpful!");
        v.addComment(c1.format());

        Comments c2 = new Comments("Bruce Banner","Hulk Smash!");
        v.addComment(c2.format());

        v.DisplayComments();

        Console.WriteLine("");


        Video v1 = new Video("Video 2","Emperor Palpatine",999);
        v1.Display();

        Comments c3 = new Comments("Anakin Skywalker","I hate you!");
        v1.addComment(c3.format());

        Comments c4 = new Comments("Obiwan Kenobi","Hello there.");
        v1.addComment(c4.format());

        Comments c5 = new Comments("General Grievious","General Kenobi!");
        v1.addComment(c5.format());

        v1.DisplayComments();

        Console.WriteLine("");


        Video v2 = new Video("Video 3","Rachel Green",777);
        v2.Display();

        Comments c6 = new Comments("Ross Geller","Pivot!");
        v2.addComment(c.format());

        Comments c7 = new Comments("Phoebe Buffey","Smelly cat, smelly cat, what are they feeding you?");
        v2.addComment(c1.format());

        Comments c8 = new Comments("Joey Tribbiani","Joey doesn't share food!");
        v2.addComment(c2.format());

        v2.DisplayComments();

        

        
    }
}