public class MathAssignment : Assignment
{
    private string _textbookSection;

    private string _problems;

    public MathAssignment(string topic, string studentName, string textbookSection, string problems) : base(topic, studentName)
    {
        _studentName = studentName;
        _topic = topic;
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"{_studentName} - {_topic} \n{_textbookSection} {_problems}");
    }
}