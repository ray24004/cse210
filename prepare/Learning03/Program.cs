using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction first = new Fraction();
        Fraction second = new Fraction(6);
        Fraction third = new Fraction(6, 7);

        Console.WriteLine($"first: {first.GetFractionString()} {first.GetDecimalValue()}");
        Console.WriteLine($"first: {second.GetFractionString()} {second.GetDecimalValue()}");
        Console.WriteLine($"first: {third.GetFractionString()} {third.GetDecimalValue()}");

        first.SetTop(3);
        first.SetBottom(6);
        Console.WriteLine($"first: {first.GetFractionString()} {first.GetDecimalValue()}");
    }
}