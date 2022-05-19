namespace fptedu.se1629;//.net 6 same as package domain in Java
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello, Everyone...");
        int x = 10, y = 11;//argruments (has values): primitive
        var name = "Dong";
        dynamic salary = 100.5;
        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());
       

        Console.WriteLine($"Total of a = {x:8} and b = {y:11} is : {sum(x, y)}");
        Console.ReadLine();
    }
    public static int sum(int a, int b)
    {
        return a + b;
    }

}

