public class Activity {
    protected string _name;

    protected string _desc;

    protected int _sec;

    string _endMessage;

    private List<string> spin = new List<string>();
    
    public void Intro() {
        Console.WriteLine($"Welcome to {_name} activity!");
        Console.WriteLine(_desc);
        Console.WriteLine("How many seconds would you like? ");
        _sec = Console.Read();
    }

    public void Outro() {

    }

    public void Display() {

    }

    public void SetSeconds() {

    }

    public void Pause() {

    }

    public void Countdown() {

    }

    public void GetReady(int Counter) {
        Console.WriteLine("Get Ready...");
        for (int i = 0; i < Counter; i++)
        {
            foreach (string character in spin)
            {
                Console.WriteLine(character);
                Thread.Sleep(250);
            }
        }
            
    }
}
