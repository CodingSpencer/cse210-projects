
public abstract class Activity {

    protected string _type;

    protected int _time;
    
    protected double _distance;

    protected virtual double _getSpeed() {
        return (_distance/_time) * 60;
    }

    protected virtual double _getPace() {
        return _time / _distance;
    }

    public virtual string _getSummary(string date) {
        return "";
    }
}