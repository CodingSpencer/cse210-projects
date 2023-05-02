public class Resume {

    //instances
    public string name;

    public List <Job> _jobs = new List<Job>();
    
    public void Display(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _jobs){
            job.Display();
            Console.WriteLine("");
        }

    }
}
