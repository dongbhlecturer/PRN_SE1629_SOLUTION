namespace Prn.Se1629;
public class Product
{
    /*1. define properties*/
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Desc { get; set; }
    public double UnitPrice { get; set; }
    public int Quantity { get; set; }
    public readonly string NameOfProvide;
    /*2. constructors*/
    public Product() {
        this.NameOfProvide = "FPT Education";
    }
    
    public Product(int id, string productName, string desc, double unitPrice, int quantity)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }
    //Expression-Bodied
    public override string? ToString() => $"[Id = {Id}, Product Name = {ProductName}, Desc = {Desc}, Unit Price = {UnitPrice} and Quantity = {Quantity}]";

    /*increate percent unit_price*/
    public void IncreaseUnitPrice(int unitPrice) => UnitPrice = UnitPrice * unitPrice/100;
}