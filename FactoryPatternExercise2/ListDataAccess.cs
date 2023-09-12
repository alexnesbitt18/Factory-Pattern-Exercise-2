using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name="Xbox", Price= 350.99m},
            new Product() { Name="Computer", Price= 500.99m},
            new Product() { Name="Cellphone", Price= 700.99m},
            new Product() { Name="Football", Price= 20.99m},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from List Data Access...");

            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a List Data Access database...");
        }
    }
}
