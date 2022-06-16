using System;
using System.IO;
using System.Data.Common;//included
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Prn.Se1629;
public class Program
{
    public static void Main()
    {
        IEnumerable<Product> products = GetAllProducts();   
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.ReadLine(); 
    }
    private static string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSettings.json",true,true)
            .Build();
        return config["ConnectionStrings:FptEduDB"];
    }
    //get all Products from database

    public static List<Product>? GetAllProducts()
    {
        //0. init variables
        string vSQL = "select * from products";
        List<Product> products = new List<Product>();
        //1. init provider (cach ket noi xuong csdl)
        DbProviderFactory factory = SqlClientFactory.Instance;
        //2. init connection (SQL Server)
        using DbConnection? conn = factory.CreateConnection();
        if(conn is null)
        {
            Console.WriteLine("init connection fail...");
            return null;
        }
        conn.ConnectionString = GetConnectionString();  
        conn.Open();
        //3. init command (sql/stored procedure)
        using DbCommand cmd = conn.CreateCommand();
        if(cmd is null)
        {
            Console.WriteLine("init connection fail(command)...");
            return null;
        }
        cmd.CommandText = vSQL;
        cmd.Connection = conn;
        //4. execute & read data
        using DbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Product p = new Product();
                p.ProductId = Convert.ToInt32(reader["ProductId"]);
                p.ProductName = Convert.ToString(reader["ProductName"]);
                p.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);

                products.Add(p);
            }
        }
        //5. return
        return products;
    } 

}