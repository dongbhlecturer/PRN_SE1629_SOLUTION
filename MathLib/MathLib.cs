namespace MathLib;

public static class MathLib
{
    public static int Add(this int a, int b) => a + b;
    public static int Sub(this int a, int b) => a - b;
    public static void Display(this int data) 
        => Console.WriteLine($"Calculation is: {data}");

}
