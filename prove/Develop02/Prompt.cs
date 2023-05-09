public class Prompt
{

    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();

    
    public Prompt()
    {
        
    }


    
void addPrompts(){
            _prompts.Add("How was your day? ");
            _prompts.Add("What was the most exciting part of your day? ");     
            _prompts.Add("What did you accomplish during your day? ");
            _prompts.Add("Who were you happiest to see today? ");

            
        }

    public string GetRandomPrompt()
    {
        if (_prompts.Count==0){
            addPrompts();
            _usedPrompts.Clear();
        }

        var random = new Random();
        int index = random.Next(_prompts.Count);
        var newPrompt = _prompts[index];
        /*_prompts.Remove(newPrompt);
        _usedPrompts.Add(newPrompt);*/
        return newPrompt;
        
    }



}
