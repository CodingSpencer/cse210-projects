public class Video {

    public string _title;

    public string _author;

    public int _length;

    List<string> comments = new List<string>();

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }

    public void addComment(string comment) {
        comments.Add(comment);
    }

    public void Display() {
        Console.WriteLine();
    }

    public void DisplayComments() {
        Console.WriteLine($"Comments - {comments.Count()}");
        foreach (string text in comments) {
            Console.WriteLine(text);
        }
        Console.WriteLine("");
    }

}