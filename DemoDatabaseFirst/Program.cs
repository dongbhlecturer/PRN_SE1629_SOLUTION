using DemoDatabaseFirst.EntitiesModels;
using Microsoft.EntityFrameworkCore;
//1. initial object DBContext
using (FptEduStoreContext db = new())
{
    IQueryable<Category> categories = db.Categories;//.Include(c => c.Products);
    foreach (var c in categories)
    {
        Console.WriteLine($"Category ID: {c.CategoryId}, Category Name: {c.CategoryName}, " +
            $"Number of Products: {c.Products.Count}");
        
        var products = from pc in c.Products
                       where pc.UnitPrice >= 18
                       select pc;
        
        //or
        /* var products2 = db.Products.Where(p => p.UnitPrice >= 18);*/



        foreach (var p in products)
        {
            Console.WriteLine($"\t - Product ID: {p.ProductId}, Product Name: {p.ProductName}, " +
                $"Unit Price: {p.UnitPrice}");
        }
    }


}

Console.ReadLine();