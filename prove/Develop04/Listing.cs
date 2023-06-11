public class Listing : Activity {
    
    public Listing() {
        _name = "Listing";
        _desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void DoActivity() {
        _sec = Intro();
        GetReady(3);
        List();
        Outro(_name, _sec);
        Spin(3);
        Console.Clear();
    }

    private void List() {
        Prompt prompt = new Prompt();
        prompt.addListPrompts();
        string reflectPrompt = prompt.GetListPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {reflectPrompt} ---");

        Console.Write("You may begin in: ");
        int i = 3;
        while (i != 0) { 
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }

        int num = 0;
        int _time = int.Parse(_sec);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        while (true) {
            Console.WriteLine("");
            Console.Write("> ");
            Console.ReadLine();
            num++;
            DateTime currentTime = DateTime.Now; 
            if (currentTime > futureTime) {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed {num} items!");
        Console.WriteLine("");
        Console.WriteLine("Well Done!!");
    }

}