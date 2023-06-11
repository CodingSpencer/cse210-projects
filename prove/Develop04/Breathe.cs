public class Breathe : Activity {
    
    public Breathe() {
        _name = "Breathing";
        _desc = "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void DoActivity() {
        Intro();
        _sec = SetSeconds();
        GetReady(3);
        InAndOut();
        Outro(_name, _sec);
        Spin(3);
        Console.Clear();
    }

    private void InAndOut() {
        int _time = int.Parse(_sec);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time); 
        while (true) {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breathe In...");
            Countdown();
            Console.WriteLine("");
            Console.Write("Breathe Out...");
            Countdown();
            DateTime currentTime = DateTime.Now; 
            if (currentTime > futureTime) {
                break;
            }
        }
        Console.WriteLine("");
    }

}