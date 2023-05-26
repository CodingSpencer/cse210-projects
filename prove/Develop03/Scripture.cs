public class Scripture{
    private string _text = "Jesus Wept.";

    List<Word> wordList = new List<Word>();

    List<int> Num = new List<int>();

    public Scripture(string scripture){
        int counter = 0;
        string[] words = scripture.Split(" ");
        foreach (string word in words){
            wordList.Add(new Word(word));
            Num.Add(counter);
            counter += 1;
        }
    }

    public void hideScripture(){
        for (int i = 0; i < 3; i++){
            var random = new Random();
            int index = random.Next(0, Num.Count);
            if (Num.Count() != 0){
            wordList[Num[index]].hideWord();
            Num.RemoveAt(index);
        }
    }
    }

    public void DisplayScripture(){
        foreach (Word word in wordList){
            word.Display();
        }
    }
}