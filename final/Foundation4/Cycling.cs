public class Cycling : Activity {
    
    public Cycling(double distance, int time) {
        _type = "Cycling";
        _distance = distance;
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
        return $"{date} {_type} ({_time} min)- Distance {_distance} miles, Speed {_getSpeed().ToString("#.##")} mph, Pace: {_getPace().ToString("#.##")} min per mile";
    }
}