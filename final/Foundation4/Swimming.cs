public class Swimming : Activity {

    int _laps;

    public Swimming(int laps, int time) {
        _type = "Swimming";
        _laps = laps;
        _distance = (laps * 50) / 1000;
        _time = time;
    }

    protected override double _getSpeed() {
        return (_distance/_time) * 60;
    }

    protected override double _getPace() {
        return _time / _distance;
    }

    public override string _getSummary(string date)
    {
        return $"{date} {_type} ({_time} min)- {_laps} Laps ,Distance {_distance} miles, Speed {_getSpeed().ToString("#.##")} mph, Pace: {_getPace().ToString("#.##")} min per mile";
    }
}