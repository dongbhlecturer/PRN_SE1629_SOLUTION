namespace Prn.Se1629;
using static System.Console;
public class Program
{
    public static void Main()
    {
        /*1. Khai bao doi tuong ManagerProduct*/
        ProductManagement productManagement = new ProductManagement();
        /*2. Them n product vao*/
        productManagement.Add(new Product(1, "Laptop Dell 15in", "new product with new features 2022", 2500, 2));
        productManagement.Add(new Product(2, "Macbook Pro 2022", "new product with new features 2022", 500, 3));
        productManagement.Add(new Product(3, "iPhone 14 Pro", "new product with new features 2022", 2500, 4));
        productManagement.Add(new Product(4, "Samsung galay note 31", "new product with new features 2022", 1360, 5));

        /*3. call display all products*/
        productManagement.Display();

    }
}
