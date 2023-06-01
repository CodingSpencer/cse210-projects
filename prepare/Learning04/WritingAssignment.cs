public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }

    public void GetWritingInformation()
    {
        Console.WriteLine($"{_studentName} - {_topic}\n{_title} by {_studentName}");
    }
}