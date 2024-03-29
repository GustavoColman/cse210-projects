using System;


// this is the class fraction
public class Fraction
{
    // this are atributes, equivalents of variables on python
    //these atributes are private
    private int _top;
    private int _bottom;


    //this is a constructor
    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    //this is a constructor
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //this is a constructor
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //this is a getter
    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        //this mehtod will show the fractional number, exemple : 1/4
        string text = $"{_top}/{_bottom}";
        return text;
    }

    //this is a getter
    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        //this method will show the decimal number of a fraction, like 0,50
        return (double)_top / (double)_bottom;
    }
}