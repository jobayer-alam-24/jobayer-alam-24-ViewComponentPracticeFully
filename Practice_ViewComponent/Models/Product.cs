using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_ViewComponent.Models
{
    public class Product
    {
        private static List<Product> _products;
        public int ID { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public static List<Product> GetProducts()
        {
            _products = new List<Product>()
            {
            new Product() { ID = 1, Name = "Dell Latitude", ISBN = "give1" },
            new Product() { ID = 2, Name = "Dell Latitude", ISBN = "give2" },
            new Product() { ID = 3, Name = "Dell Latitude", ISBN = "give3" },
            new Product() { ID = 4, Name = "Dell Latitude", ISBN = "give4" },
            new Product() { ID = 5, Name = "Dell Latitude", ISBN = "give5" },
            new Product() { ID = 6, Name = "Dell Latitude", ISBN = "give6" },
            new Product() { ID = 7, Name = "Dell Latitude", ISBN = "give7" },
            new Product() { ID = 8, Name = "Dell Latitude", ISBN = "give8" },
            new Product() { ID = 9, Name = "Dell Latitude", ISBN = "give9" },
            new Product() { ID = 10, Name = "Dell Latitude", ISBN = "give10" }
            };
            return _products;
        }
    }
}