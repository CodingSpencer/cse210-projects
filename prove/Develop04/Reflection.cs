public class Reflection : Activity {

    List<string> _questions = new List<string>();
    List<string> _usedQuestions = new List<string>();


    public Reflection() {
        _name = "Reflection";
        _desc = "This activity will help  you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void DoActivity() {
        _sec = Intro();
        GetReady(3);
        Reflect();
        Outro(_name, _sec);
        Spin(3);
        Console.Clear();
    }

    private void addReflectQuestions() {
        _questions.Add("What is your take away from this experience?");
        _questions.Add("How has this experience changed you?");
        _questions.Add("How will you move forward from this experience?");
        _questions.Add("Did this experience positively influence you? If not, why?");
        _questions.Add("What lesson did you learn from this experience?");
        _questions.Add("What would you tell your future self about this experience?");
        _questions.Add("If you had one year left to live, what would you do?");
    }
    
    public string GetReflectQuestion()
    {
        _questions.Clear();
        addReflectQuestions();
        if (_questions.Count==0){
            addReflectQuestions();
            _usedQuestions.Clear();
        }

        var random = new Random();
        int index = random.Next(0, _questions.Count);
        var newPrompt = _questions[index];
        _usedQuestions.Remove(newPrompt);
        _usedQuestions.Add(newPrompt);
        return newPrompt;
    }

    private void Reflect() {
        Prompt prompt = new Prompt();
        prompt.addReflectPrompts();
        string reflectPrompt = prompt.GetReflectPrompt();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {reflectPrompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        if (input == "") {
            
                }
        Console.WriteLine("");
        Console.WriteLine("Now Ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown();
        Console.Clear();
        addReflectQuestions();
        int _time = int.Parse(_sec);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        while (true) { 
            string question = GetReflectQuestion();
            Console.WriteLine("");
            Console.WriteLine(question);
            Spin(5);
            DateTime currentTime = DateTime.Now; 
            if (currentTime > futureTime) {
                break;
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Well Done!!");
    }
 
}