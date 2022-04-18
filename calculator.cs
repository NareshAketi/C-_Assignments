using System;
namespace Calculator;
public class Calculator_Operations
{
    public static void Main()
    {
        Console.WriteLine("Enter 1st number:");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd number:");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition: {0}", c + g);
        Console.WriteLine("Subtraction: {0}", c - g);
        Console.WriteLine("Multiplication: {0}", c * g);
        Console.WriteLine("Division: {0}", c / g);
    }
}