public class DVD : Loanable
{


    public DVD(string title) : base(title)
    {
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Title: {_title}");
    }
}