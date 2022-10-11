using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternsDataBase
{
    public class SQLDataAccess : IDataAccess
    {
       public List<Product> LoadData()
        {
            Console.WriteLine("I am reading the data from SQL Database....");
            return new List<Product>()
            {
            new Product() {Name = "GeForce RTX 3050", Price = 239.99m},
            new Product() {Name = "GeForce RTX 3060", Price = 329.99m},
            new Product() {Name = "GeForce RTX 3060TI", Price = 399.99m},
            new Product() {Name = "GeForce RTX 3070", Price = 499.99m},
            new Product() {Name = "GeForce RTX 3070TI", Price = 599.99m},
            new Product() {Name = "GeForce RTX 3080", Price = 699.99m},
            new Product() {Name = "GeForce RTX 3080TI", Price = 1199.99m},
            new Product() {Name = "GeForce RTX 3090", Price = 1499.99m},
            new Product() {Name = "GeForce RTX 3090TI", Price = 1999.99m}
            };
        }
        public void SaveData()
        {
            Console.WriteLine("i am saving data from SQL Database!");
        }
    }
}
