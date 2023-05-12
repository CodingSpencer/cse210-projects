using System;

class Program
{
    static void Main(string[] args)
    {
        
        Prompt prompt = new Prompt();
        Entries entries = new Entries();
        Journal journal = new Journal();

        while (true){
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please enter one of the following:");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.WriteLine("What would you like to do?");
            string menuOption = Console.ReadLine();

            if (menuOption == "1"){
                
                DateTime theCurrentTime = DateTime.Now;
                entries.date = theCurrentTime.ToShortDateString();

                Console.WriteLine("Rate The Day (1-10): ");
                entries.rating = Console.ReadLine();

                string person = "";
                while (person != "done"){
                    Console.WriteLine("Please enter the people you were with today individually and enter done when complete.");
                    person = Console.ReadLine();
                    entries.people.Add(person);
                    if (person == "done"){
                        entries.people.Remove("done");
                    }
                }
                entries.PeopleList();

                entries.prompt = prompt.GetRandomPrompt();
                Console.WriteLine($"{entries.prompt}");

                entries.entry = Console.ReadLine();

                entries.saveEntries.Add(entries.Display());
            }
            if (menuOption == "2"){
                entries.entriesList();
            }
            if (menuOption == "3"){
                List<string> savedEntires = journal.ReadFromFile();
                foreach (string entry in savedEntires){
                    Console.WriteLine(entry);
                }
            }
            if (menuOption == "4"){
                journal.SaveToFile(entries.saveEntries);
            }
            if (menuOption == "5"){
                break;
            }
        }

        
        
    }
}

// My list is updating all the objects in it instead of just adding the new one