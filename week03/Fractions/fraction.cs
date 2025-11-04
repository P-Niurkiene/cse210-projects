using System.Reflection;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
        //Console.WriteLine($"{_topNumber} / {_bottomNumber}");
    }

    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
        //Console.WriteLine($"{_topNumber} / {_bottomNumber}");
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
        //Console.WriteLine($"{_topNumber} / {_bottomNumber}");
    }

    public int getTop()
    {
        return _topNumber;
    }

    public void setTop(int top)
    {
        _topNumber = top;
    }

    public int getBottom()
    {
        return _bottomNumber;
    }

    public void setBottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}