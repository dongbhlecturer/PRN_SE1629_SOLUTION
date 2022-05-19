namespace Prn.Se1629;
public interface IProduct
{
    public abstract void Add(Product p);
    public abstract bool Update(Product p);
    public abstract bool Delete(Product p);
    public abstract Product GetProduct(int productID);

    void Display();
}