using System.Collections;
using static System.Console;
namespace PRN.SE1629;

public class Program
{
    public static void Main(string[] args)
    {
        /*1. create a new object Employee*/
        /*
        Employee e = new Employee();
        e.Id = 1;
        e.Name = "Dong";
        e.Salary = 150.55d;
        */

        //Employee emp = new Employee(160d,1,"Nguyen Van A");
        //emp.Name = "Nguyen Cong PHuong";
        //WriteLine(emp);

        /*2. create a list employees and display them*/
        /*
                ArrayList lstEmps = new ArrayList(); 
                lstEmps.Add(new Employee(100,1,"Dong"));
                lstEmps.Add(new Employee(520, 2, "Minh"));
                lstEmps.Add(new Employee(300, 3, "Binh"));
                lstEmps.Add(new Employee(500, 4, "Hai"));
                lstEmps.Add(new Employee(1500, 5, "Lam"));
                lstEmps.Add(new Employee(580, 6, "Xuan"));
                lstEmps.Add(new Employee(6330, 7, "Tuong"));
                lstEmps.Add("Pack Hang Seo");
        */
        Employee a = new Employee(1,"Dong",152d,new DateOnly(),new Address(493,"CMT8","P.13","Quan 10","HCMC"));

       
   
        
        WriteLine(a);

        //display
        //Display(lstEmps);



       

        ReadLine();

    }

   private static void Display(ArrayList lstData)
    {
        /*
        foreach (Employee e in lstData)
        {
            WriteLine(e);
        }
        */
        for(int i = 0; i < lstData.Count; i++)
        {
            WriteLine(lstData[i]);
        }
    }
    
}