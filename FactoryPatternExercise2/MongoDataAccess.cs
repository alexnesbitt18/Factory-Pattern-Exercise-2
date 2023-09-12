using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a Mongo Data Access database...");
        }
        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine($"I am reading data from the SQL Data Access database...");

            return new List<Product>()
            {
                new Product() { Name = "Xbox", Price = 350.99m },
                new Product() { Name = "Computer", Price = 500.99m },
                new Product() { Name = "Cellphone", Price = 700.99m },
                new Product() { Name = "Football", Price = 20.99m },
            };
        }
    }
}
