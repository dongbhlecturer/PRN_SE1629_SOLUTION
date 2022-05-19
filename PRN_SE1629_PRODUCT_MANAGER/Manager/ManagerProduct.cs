namespace Prn.Se1629;
public class ProductManagement:IProduct
{
    private Product[] lstProduct;
    private int size; //So luong phan tu that trong mang 1 chieu lstProduct
    public ProductManagement()
    {
        this.size = 0;
        this.LstProduct = new Product[Utils.InitLengProduct];
    }
    public ProductManagement(Product[] lstProducts)
    {
        this.LstProduct = lstProducts;
        foreach (Product p in lstProducts)
        {
            if (p != null)
            {
                this.size++;
            }
        }
    }

    public Product[] LstProduct { get => lstProduct; set => lstProduct = value; }

    public void Add(Product p)
    {
        //Viet giai thuat de thuc thi chen 1 phan tu vao 1 mang 1 chieu tinh
        /*1. check de xem mang con trong khong?*/
        CheckSize();
        /*2. Neu ma con cho trong, thi ta chi viec add product vao*/
        this.lstProduct[this.size++] = p;
    }

    private void CheckSize()
    {
        if (this.size >= this.LstProduct.Length)
        {
            //thuc hien noi mang ra
            Product[] tmp = new Product[this.size * 2];
            //hot du lieu tu cu sang mang temp moi nay
            for (int i = 0; i < this.size; i++)
            {
                tmp[i] = this.LstProduct[i];
            }
            this.lstProduct = tmp;
        }
    }

    public bool Delete(Product p)
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        foreach (Product p in this.LstProduct)
        {
            Console.WriteLine(p);
        }
    }

    public Product GetProduct(int productID)
    {
        throw new NotImplementedException();
    }

    public bool Update(Product p)
    {
        throw new NotImplementedException();
    }
}