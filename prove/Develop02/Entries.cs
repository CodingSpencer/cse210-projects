public class Entries{
    public string prompt;

    public string date;

    public string entry;

    public string rating;

    public string lovedOnes;

    public List<string> people = new List<string>();

    public List<string> saveEntries = new List<string>();

    Program program = new Program();

    public string Display(){
        return $"{date} - {prompt}\nRating: {rating} People: {lovedOnes}\nEntry: {entry}";
    }

    public void entriesList(){
        foreach (string displayEntry in saveEntries){
                Console.WriteLine(displayEntry);
                }
    }

    public void PeopleList(){
        lovedOnes = String.Join(", ", people);
    }

}