using System.IO;

public class SaveFile {

    public void SaveToFile(List<Goal> goals){
        Console.WriteLine("Saved to file...");
        string filename = "Goals.txt";
        
        using (StreamWriter outputfile = new StreamWriter(filename)){
            foreach (Goal goal in goals){
            outputfile.WriteLine(goal.getSaveFormat());
        }
        }
    }
    

    public List<string> ReadFromFile(List<Goal> goals){
        Console.WriteLine("Loaded from file...");
        List<string> savedEntries = new List<string>();
        string filename = "Goals.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines){
            string[] type = line.Split(":");
            if (type[0] == "Simple") {
                string[] data = type[1].Split(",");
                Simple simple = new Simple("Simple");
                simple.loadGoal(data[0], data[1], data[2], data[3], data[4]);
                goals.Add(simple);
            }
            else if (type[0] == "Eternal") {
                string[] data = type[1].Split(",");
                Eternal eternal = new Eternal("Eternal");
                eternal.loadGoal(data[0], data[1], data[2], data[3], data[4]);
                goals.Add(eternal);
            }
            else {
                string[] data = type[1].Split(",");
                Checklist checklist = new Checklist("Checklist");
                checklist.loadCheck(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
                goals.Add(checklist);
            }
        }

        return savedEntries;
        
    }
}