using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract = new Fraction();
        Console.WriteLine(fract.GetFractionString());
        Console.WriteLine(fract.GetDecimalValue());
        fract.SetTop(5);
        Console.WriteLine(fract.GetFractionString());
        Console.WriteLine(fract.GetDecimalValue());
        fract.SetTop(1);
        fract.SetBottom(3);
        Console.WriteLine(fract.GetFractionString());
        Console.WriteLine(fract.GetDecimalValue());
        fract.SetTop(3);
        fract.SetBottom(4);
        Console.WriteLine(fract.GetFractionString());
        Console.WriteLine(fract.GetDecimalValue());


    }
}