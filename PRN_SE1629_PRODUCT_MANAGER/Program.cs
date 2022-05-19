namespace Prn.Se1629;
using static System.Console;
public class Program
{
    public static void Main()
    {
        /*1. Khai bao doi tuong ManagerProduct*/
        ProductManagement productManagement = new ProductManagement();
        Product p = new Product(3, "iPhone 14 Pro", "new product with new features 2022", 2500, 4);
        /*2. Them n product vao*/
        productManagement.Add(new Product(1, "Laptop Dell 15in", "new product with new features 2022", 2500, 2));
        productManagement.Add(new Product(2, "Macbook Pro 2022", "new product with new features 2022", 500, 3));
        productManagement.Add(p);
        productManagement.Add(new Product(4, "Samsung galay note 31", "new product with new features 2022", 1360, 5));
        /*3. call display all products*/
        productManagement.Display();


        WriteLine("----------------------------------");
        /*4. Loc theo 1 tieu chi nao do*/
        //Lay het cac san pham ra
        Product[] lstData = FilterProduct(2000, productManagement.LstProduct);
        foreach (Product pf in lstData)
        {
            if(pf != null)
            {
                WriteLine(pf);
            }
        }

        Console.ReadLine();

        /*4. Xoa p*/
        //productManagement.Delete(p);
        //WriteLine("----------------------------------");
        /*5. call display all products*/
        //productManagement.Display();

    }

    private static Product[] FilterProduct(double unitPrice, Product[] lstData)
    {
        Product[] resultData = new Product[lstData.Length];
        int i = 0;
        foreach (Product p in lstData)
        {
            if(p.UnitPrice >= unitPrice)
            {
                resultData[i] = p;
                i++;
            }
        }
        return resultData;
    }


}
