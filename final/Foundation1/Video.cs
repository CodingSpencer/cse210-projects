public class Video {

    string _title;

    string _author;

    int _length;

    List<string> comments = new List<string>();


    List<Video> videos = new List<Video>();

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }

    public void addComment(string comment) {
        comments.Add(comment);
    }

    public void Display() {
        Console.WriteLine($"{_title} - {_author} - {_length} seconds");
    }

    public void DisplayComments() {
        Console.WriteLine("Comments");
        foreach (string text in comments) {
            Console.WriteLine(text);
        }
    }

}