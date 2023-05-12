using System.IO;

public class Journal{
    
public void SaveToFile(List<string> saveEntries){
    Console.WriteLine("Saving to file...");
    string filename = "journal.csv";

    using (StreamWriter outputfile = new StreamWriter(filename)){
        foreach (string entry in saveEntries){
            outputfile.WriteLine(entry);
        }
        }
    }

    public List<string> ReadFromFile(){
        Console.WriteLine("Reading from file...");
        List<string> savedEntries = new List<string>();
        string filename = "journal.csv";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines){
            Console.WriteLine(line);
        }

        return savedEntries;
        
    }

    
}




