public class Reception : Event {
    
    bool _isRVSP = false;

    string _email;

    string _reserved;

    public Reception(string title, string desc, string date, string time, string address) {
        _type = "Reception";
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public void setExtra(string email) {
        _email = email;
        _isRVSP = true;
        if (_isRVSP == true) {
            _reserved = "X";
        }
    }

    public string getExtra() {
        return $"Email: {_email} -[{_reserved}]";
    }
}