public class Score : Goal {

    public override void Display(int index) {

    }

    public int getPoints(Goal goal) {
        int points = goal._points;
        return points;
    }

    public int setScore(int points, bool complete) {
        if (complete == false) {
        _score += points;
        }
        return _score;
    }



}