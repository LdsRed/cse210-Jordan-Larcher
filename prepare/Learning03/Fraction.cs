

using System.Diagnostics;
using System.Diagnostics.Contracts;

class Fraction {

    private int _numerator;
    private int _denominator;

    public Fraction(){
        this._numerator = 1;
        this._denominator = 1;
    
    }

    public Fraction(int top){
        SetNumerator(top);
        this._denominator = 1;
    
    }

    public Fraction(int top, int bottom){
        SetNumerator(top);
        SetDenominator(bottom);
    }



    public int GetNumerator(){
        return this._numerator;
    }

    public int GetDenominator(){
        return this._denominator;
    }

    

    public void SetNumerator(int top){
        this._numerator = top;
    }

    public void SetDenominator(int bottom){
        this._denominator = bottom;
    }


    public string GetFractionString(){
        return $"{_numerator}/{_denominator}";
    }


    public double GetDecimalValue(){
        return (double) _numerator/ (double) _denominator;
    }




}