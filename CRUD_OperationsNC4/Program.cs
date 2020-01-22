using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CRUD_OperationsNC4
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultKey = File.ReadAllText("appsettings.Debug.JSON");
            JObject jObject = JObject.Parse(defaultKey);
            Console.WriteLine(jObject);






            //ProductRepo repo = new ProductRepo();

            //Create Products

            //Console.WriteLine("Creating Product.....");
            //var newProduct = new Product { Name = "Jeffs Product", Price = 19.99M, CategoryID = 2, OnSale = 0 };
            //repo.CreateProduct(newProduct);
            //Console.WriteLine("Product Created!");

            //Update Products

            //Console.WriteLine("Updating Product.....");
            //var newInfo = new Product { ProductID = 941, StockLevel = 27 };
            //repo.UpdateProduct(newInfo);
            //Console.WriteLine("Product Update!");

            //Delete ProductID
            //Console.WriteLine("Deleting Product.....");
            //repo.DeleteProduct(941);

            //Delete Product by name
            //Console.WriteLine("Deleting Product.....");
            //repo.DeleteProduct("Jeffs Product 1");

            //Delete Product by name
            //Console.WriteLine("Deleting Product.....");
            //repo.DeleteProduct(944, "Jeffs Product 2");

            // Read Products

            //List<Product> products = repo.GetProducts();
            //foreach (var prod in products)
            {
                //Console.WriteLine($"{prod.ProductID}  {prod.Name} ------- ${prod.Price}------- You have {prod.StockLevel} of these items");
            }
        }
    }
}
