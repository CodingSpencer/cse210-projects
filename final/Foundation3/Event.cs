public class Event {

    protected bool _isReserved = false;

    protected string _title;

    protected string _desc;

    protected string _date;

    protected string _time;

    protected string _address;

    protected string _type;

    public void Display() {
        Console.WriteLine($"{_title} - {_desc}\n{_date} - {_time}\n{_address}");
    }

    public void Display1(string extra) {
        Console.WriteLine($"{_title} - {_desc}\n{_date} - {_time}\n{_address}\n{extra}");
    }

    public void Display2() {
        Console.WriteLine($"{_type} - {_title} - {_date}");
    }
}