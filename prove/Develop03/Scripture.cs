public class Scripture{
    private string _text = "Jesus Wept.";

    //List<string> words = new List<string>();

    public void makingList(){
        string[] words = _text.Split(" ");
        //string cleanWords = words.Remove
        foreach (string word in words)
    {
        foreach (char letter in word){
            if (Char.IsLetter(letter) == false){
                word.Remove()
            }
            else{

            }
        }
    }
    }

}