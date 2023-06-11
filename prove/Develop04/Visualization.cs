public class Visualization : Activity {
    
    List<string> _prompts = new List<string>();

    public Visualization() {
        _name = "Visualization";
        _desc = "This activity will help you visualize an event in your future and the ways you could possibly succeed or fail.";
    }

    public void DoActivity() {
        _sec = Intro();
        GetReady(3);
        Visualize();
        Outro(_name, _sec);
        Spin(3);
        Console.Clear();
    }

    void Visualize() {
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- Think of an event you've been trying to  prepare for. ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        if (input == "") {
            
                }
        
        Console.WriteLine("Now prepare to read prompts on what to imagine with this experience.");
        Console.Write("You may begin in: ");
        Countdown();

        foreach (string prompt in _prompts) {
            Console.WriteLine(prompt);
            Console.Write("How would you respond? ");
            Spin(20);
        }

    }

    void addVisualizationPrompts() {
        _prompts.Add("Imagine waking up the day of the event having not prepared.");
        _prompts.Add("Imagine showing up to the event to learn you prepared incorrectly.");
        _prompts.Add("Imagine during the event your plan has to change.");
        _prompts.Add("Imagine that someone does something that messes up your performance.");
        _prompts.Add("What is the biggest thing you're scared of going wrong? Imagine it happening.");
        _prompts.Add("Imagine everything going the best way possible.");
    }

}