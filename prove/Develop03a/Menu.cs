public class Menu{


    public Menu(){

    }

    Selector selector = new Selector();
    Scripture scripture = new Scripture();

    public void GetReference()
    {
        Console.WriteLine(selector.finalReference);
    }

    public void GetScripture()
    {
        Console.WriteLine(selector.finalScripture);
    }

    public void runMenu()
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!\n1. Memorize\n 2. Quit");
        string selcetion = Console.ReadLine();
        while (true){
                if (selcetion == "1"){
                    selector.Random();
                    int index = selector._index;
                    GetReference();
                    selector.scriptureSelector(index);
                    while (true){
                        string input = Console.ReadLine();
                        if (scripture.Num.Count() == 0){
                            Console.WriteLine("You completed memorizing the scripture!");
                            break;
                        }
                        else if (input == ""){
                            
                            scripture.hideScripture();
                            GetReference();
                            scripture.DisplayScripture();
                        }
                        else if (input == "quit"){
                            Console.WriteLine("Thanks for playing!");
                            break;
                        }
                else if (selcetion == "2"){
                    break;
                    }
                    }
    }
}
    }
}