using System.IO;

public class SaveFile : Goal {

    public override void Display(int index) {

    }

    public void SaveToFile(List<Goal> goals){
    Console.WriteLine("Saving to file...");
    string filename = "Goals.txt";

    
        
        Checklist checklist = new Checklist("Checklist");
        foreach (Goal goal in goals){
            string type = _type;
            using (StreamWriter outputfile = new StreamWriter(filename)){
            if (type == "Checklist") {
                outputfile.WriteLine($"{_type}:{_goalName}, {_desc}, {_points}, {checklist._bonusPoints} {_isCompleted}, {checklist._times}, {checklist._progress} ");
            }
            else {
                outputfile.WriteLine($"{_type}:{_goalName}, {_desc}, {_points}, {_isCompleted}");
            }
        }
        }
    }
    

    public List<string> ReadFromFile(){
        Console.WriteLine("Reading from file...");
        List<string> savedEntries = new List<string>();
        string filename = "Goals.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines){
            Console.WriteLine(line);
        }

        return savedEntries;
        
    }
}