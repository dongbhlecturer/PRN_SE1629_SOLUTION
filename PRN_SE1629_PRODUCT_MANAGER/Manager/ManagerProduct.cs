namespace Prn.Se1629;
public class ProductManagement:IProduct
{
    private Product[] lstProduct;
    private int size; //So luong phan tu that trong mang 1 chieu lstProduct
    public Product[] LstProduct { get => lstProduct; set => lstProduct = value; }
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
        int index = 0;
        /*1. tim phan p do co trong mang hay khong? */
        foreach (var item in this.lstProduct)
        {
            index++;
            if(item is not null && item.Id == p.Id)
            {
               /*Neu tim thay roi thi xoa di*/
               for(int i = index; i < size-1; i++)
                {
                    lstProduct[i] = lstProduct[i + 1];
                }
                lstProduct[this.size-1] = null;
                return true;
            }
        }
        return false;
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