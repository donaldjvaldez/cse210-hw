public class Fraction {
    private int _top;
    private int _bottom;

    // constructor 1 (no parameters)
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    // constructor 2 (one parameter)
    public Fraction(int top){
        _top = top;
        _bottom = 1;
    }
    // constructor 3 (two parameters)
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    // Getters and Setters
    public int GetTop() {
        return _top;
    }
    public void SetTop(int top) {
        _top = top;
    }
    public int GetBottom() {
        return _bottom;
    }
    public void SetBottom(int bottom) {
        _bottom = bottom;
    }
    public string GetFractionString() {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue() {
        return (double)_top / (double)_bottom;
    }
}