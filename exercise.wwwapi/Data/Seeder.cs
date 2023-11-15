using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{
    public static class Seeder
    {
        public static List<Product> GetListOfProducts()
        {
            var products = new List<Product>()
            {
                new Product() {Name="Fender Stratocaster", Description="Electric Guitar", Price=1200.00m }
                

            };

          

            return products;
        }
    }
}
