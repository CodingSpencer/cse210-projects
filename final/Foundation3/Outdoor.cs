public class Outdoor : Event {
    
    string _weather;

    public Outdoor(string title, string desc, string date, string time, string address) {
        _type = "Outdoor Activity";
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public void setExtra(string weather) {
        _weather = weather;
    }

    public string getExtra() {
        return $"Weather: {_weather}";

    }
}