using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company ="Microsoft";
        job1._jobtitle = "Programmer";
        job1._startYear = 2016;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobtitle = "Secrity";
        job2._startYear = 2010;
        job2._endYear = 2016;

        Resume myResume = new Resume();
        myResume.name = "Steve Rogers";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}