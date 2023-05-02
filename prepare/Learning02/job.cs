public class Job {

    //instances
    public string _company;
    public string _jobtitle;
    public int _startYear;
    public int _endYear;

    public void Display(){
        Console.Write($"{_company} {_jobtitle} {_startYear}-{_endYear}");
    }

    }

