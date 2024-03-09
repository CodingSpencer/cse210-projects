public class Lecture : Event {

    string _speaker;

    int _capacity;

    public Lecture(string title, string desc, string date, string time, string address) {
        _type = "Lecture";
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public void setExtra(string speaker, int capacity) {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string getExtra() {
        return $"Speaker: {_speaker} - Capacity: {_capacity}";
    }
}