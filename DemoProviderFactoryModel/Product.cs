namespace Prn.Se1629;
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double UnitPrice { get; set; }
    public Product() { }

    public Product(int productId, string productName, double unitPrice)
    {
        ProductId = productId;
        ProductName = productName;
        UnitPrice = unitPrice;
    }

    public override string? ToString() => $"[Product ID: {ProductId}], " +
        $"Product Name: {ProductName} and Unit Price: {UnitPrice}";
}