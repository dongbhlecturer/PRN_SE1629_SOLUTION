using System.IO;
using System.Text;

namespace Prn.FileStreamDemo;
public class Program
{
    public static void Main()
    {
        string msg = "ABCDEF";
        using FileStream fileStream = File.Open("data.dat", FileMode.Create);
        byte[] msgBytes = Encoding.UTF8.GetBytes(msg);

        //write msgBytes xuong file data.dat
        fileStream.Write(msgBytes, 0, msgBytes.Length);
        fileStream.Position = 0;//dua ve vi tri tu dau
    }

}