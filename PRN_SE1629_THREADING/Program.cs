using static System.Console;
namespace Prn.Se1629;
public class Program
{
    public static void Main()
    {
        //1. dong bo
        /*
        PrintNumber();
        WriteLine("================");
        PrintNumber();
        WriteLine("================");
        PrintNumber();
        */
        //2. tao ra 3 thread, moi thread thuc thi loi goi PrintNumber

        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(() => {
                PrintNumber(i);
            });
            t.Start();
        }





    }

    public static void PrintNumber(int indexThread)
    {
        for(int i = 1; i <=5; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Thread {indexThread}: {i}");
        }
    }
}


