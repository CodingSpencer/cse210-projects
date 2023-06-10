public class Prompt {

    List<string> _usedPrompts1 = new List<string>();
    List<string> _prompts1 = new List<string>();

    private void addReflectPrompts() {
        _prompts1.Add("What is your take away from today?");
        _prompts1.Add("How has today changed you?");
        _prompts1.Add("How will you move forward from today?");
        _prompts1.Add("Did today positively influence you? If not, why?");
        _prompts1.Add("What lesson did you learn from this experience?");
        _prompts1.Add("What would you tell your future self?");
        _prompts1.Add("If you had one year left to live, what would you do?");
    }

    List<string> _usedPrompts2 = new List<string>();
    List<string> _prompts2 = new List<string>();

    private void addListPrompts() {
        _prompts2.Add("When have you felt the Holy Ghost this month?");
        _prompts2.Add("What have been your top experinces this month?");
        _prompts2.Add("What are some challenges you have overcome this month?");
        _prompts2.Add("What are some new goals you've made this month?");
        _prompts2.Add("What are the things you've been most grateful for this month?");
    }
    
    public string GetReflectPrompt()
    {
        if (_prompts1.Count==0){
            addReflectPrompts();
            _usedPrompts1.Clear();
        }

        var random = new Random();
        int index = random.Next(0, _prompts1.Count);
        var newPrompt = _prompts1[index];
        _prompts1.Remove(newPrompt);
        _usedPrompts1.Add(newPrompt);
        return newPrompt;
        
    }
}