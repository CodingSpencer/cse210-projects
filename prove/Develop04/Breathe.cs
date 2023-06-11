public class Breathe : Activity {
    
    public Breathe() {
        _name = "Breathing";
        _desc = "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void DoActivity() {
        _sec = Intro();
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
            if (currentTime > futureTime) {
                break;
            }
        }
        Console.WriteLine("");
    }

}