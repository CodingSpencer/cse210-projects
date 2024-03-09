public class Prompt {

    public Prompt() {

    }

    List<string> _prompts1 = new List<string>();

    public void addReflectPrompts() {
        _prompts1.Add("Think of a time when you did something really difficult.");
        _prompts1.Add("Think of your proudest moment.");
        _prompts1.Add("Think of your best memory with a loved one.");
        _prompts1.Add("Think of your lowest moment.");
        _prompts1.Add("Think of a memory when you tried to meet a goal.");
        _prompts1.Add("Think of when you've served someone else.");
        _prompts1.Add("Think of what you're most excited to do in the future.");
    }

    List<string> _usedPrompts2 = new List<string>();
    List<string> _prompts2 = new List<string>();

    public void addListPrompts() {
        _prompts2.Add("When have you felt the Holy Ghost this month?");
        _prompts2.Add("What have been your top experinces this month?");
        _prompts2.Add("What are some challenges you have overcome this month?");
        _prompts2.Add("What are some new goals you've made this month?");
        _prompts2.Add("What are the things you've been most grateful for this month?");
    }
    
    public string GetReflectPrompt()
    {
        var random = new Random();
        int index = random.Next(0, _prompts1.Count);
        var newPrompt = _prompts1[index];
        return newPrompt;
        
    }

    public string GetListPrompt()
    {
        if (_prompts2.Count==0){
            addReflectPrompts();
            _usedPrompts2.Clear();
        }

        var random = new Random();
        int index = random.Next(0, _prompts2.Count);
        var newPrompt = _prompts2[index];
        _prompts2.Remove(newPrompt);
        _usedPrompts2.Add(newPrompt);
        return newPrompt;
        
    }
}