public class Activity {  
    
    protected string _name;

    protected string _desc;

    protected string _sec;

    private List<string> spin = new List<string>() { "/", "|" ,@"\"};

    public void Intro() {
        Console.WriteLine("");
        Console.WriteLine($"Welcome to {_name} activity!");
        Console.WriteLine(_desc);
    }
    
    public void Outro(string name, string time) {
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {time} seconds of the {name} Activity.");
    }

    public void Display() {

    }

    public string SetSeconds() {
        Console.WriteLine("");
        Console.WriteLine("How many seconds would you like? ");
        _sec = Console.ReadLine();
        Console.Clear();
        return _sec;
    }

    public void Spin(int Counter) {
       for (int i = 0; i < Counter; i++)
        {
            
            foreach (string character in spin)
            {
                Console.Write(character);
                Thread.Sleep(333);
                Console.Write("\b \b");
            }
        }
    }

    public void Countdown() {
        int i = 3;
        while (i != 0) { 
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
    }

    public void GetReady(int Counter) {
        Console.WriteLine("");
        Console.Write("Get Ready...");
        for (int i = 0; i < Counter; i++)
        {
            
            foreach (string character in spin)
            {
                Console.Write(character);
                Thread.Sleep(333);
                Console.Write("\b \b");
            }
        }
            
    }
}
