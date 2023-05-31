public class Loanable
{
    protected string _title;

    public Loanable(string title)
    {
        _title = title;
    }

    protected bool _isCheckedIn = true;

    public void CheckOut()
    {
        _isCheckedIn = false;
    }


    public void CheckIn()
    {
        _isCheckedIn = true;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Available: {_isCheckedIn}");
    }
}