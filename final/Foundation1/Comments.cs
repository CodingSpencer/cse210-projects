public class Comments {

    string _name;

    string _comment;

    public Comments(string name, string comment) {
        _name = name;
        _comment = comment;
    }

    public string format() {
        return $"{_name}-{_comment}";
    }

    





}