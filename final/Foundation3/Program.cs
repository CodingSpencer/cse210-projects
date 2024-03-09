using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("2 South 2 West", "Denver", "Colorado", "US");
        Lecture l1 = new Lecture("Coding for Noobs", "Come learn from professional coders how to best code beginner projects.", "01/01/2024", "7:00", a1.getAddress());
        Console.WriteLine("");
        l1.Display();
        Console.WriteLine("");
        l1.setExtra("Steve Jobs", 50);
        l1.Display1(l1.getExtra());
        Console.WriteLine("");
        l1.Display2();

        Address a2 = new Address("1 North 3 East", "Phoenix", "Arizona", "US");
        Reception r1 = new Reception("Steve's Wedding Reception", "Come celebrate with Steve and his family.", "11/15/2023", "4:00", a2.getAddress());
        Console.WriteLine("");
        r1.Display();
        Console.WriteLine("");
        r1.setExtra("jennifer@gmail.com");
        r1.Display1(r1.getExtra());
        Console.WriteLine("");
        r1.Display2();

        Address a3 = new Address("1 South 5 East", "Charleston", "West Virginia", "US");
        Outdoor o1 = new Outdoor("Run for Kids", "Come encourage young kids to live a healthy lifestyle and learn to be active.", "07/31/2023", "10:00", a3.getAddress());
        Console.WriteLine("");
        o1.Display();
        Console.WriteLine("");
        o1.setExtra("90 Sunny");
        o1.Display1(o1.getExtra());
        Console.WriteLine("");
        o1.Display2();

    }
}