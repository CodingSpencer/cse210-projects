public class Breathe : Activity {
    
    public Breathe() {
        _name = "Breathing";
        _desc = "This activity will help  you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void DoActivity() {
        _sec = Intro();
        GetReady(5);
        InAndOut();
        Outro(_name, _sec);
    }

    private void InAndOut() {
        int _time = int.Parse(_sec);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time); 
        while (true) {
            Console.WriteLine("");
            int i = 3;
            Console.WriteLine("");
            Console.Write("Breathe In...");
            while (i != 0) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i--;
            }
            i = 3;
            Console.WriteLine("");
            Console.Write("Breathe Out...");
            while (i != 0) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i--;
            }
            DateTime currentTime = DateTime.Now; 
            if (currentTime >futureTime) {
                break;
            }
        }
    }

}