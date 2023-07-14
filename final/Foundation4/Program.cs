using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        List<string> activities = new List<string>();

        Running r1 = new Running(5.3, 50);
        activities.Add(r1._getSummary(dateText));

        Swimming s1 = new Swimming(50, 30);
        activities.Add(s1._getSummary(dateText));

        Cycling c1 = new Cycling(10.5, 65);
        activities.Add(c1._getSummary(dateText));

        foreach (string activity in activities) {
            Console.WriteLine("");
            Console.WriteLine(activity);
        }
    }
}