using System;
using System.Collections.Generic;

namespace FactoryPatternsDataBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("What database would you like you use");
            Console.WriteLine("Please enter: Regular or list for a static list.");
            Console.WriteLine("Please enter: Sql for a MySQL DB.");
            Console.WriteLine("Please enter: Mongo for a Mongo DB.");
            var dataBaseChose = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(dataBaseChose);
            List<Product> products = data.LoadData();
            data.SaveData();

            Console.WriteLine("-----------------------------");

            Console.WriteLine();
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} | " +
                    $"Product Price: {product.Price,0:c}");
            }




        }
    }
}
