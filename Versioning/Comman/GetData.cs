using Versioning.Model;

namespace Versioning.Comman
{
    public class GetData
    {
        public static List<Product> GetProductsV1()
        {
            var listProduct = new List<Product>()
            {
                new Product { Id = 1, Name = "Apple", Price = 1.50, Category = "Fruit" },
                new Product { Id = 2, Name = "Bread", Price = 2.25, Category = "Bakery" }
            };
            return listProduct;
        }

        public static List<Product> GetProductsV2()
        {
            var listProduct = new List<Product>()
            {
                new Product { Id = 1, Name = "Apple", Price = 1.50, Category = "Fruit" },
                new Product { Id = 2, Name = "Bread", Price = 2.25, Category = "Bakery" },
                new Product { Id = 3, Name = "Carrot", Price = 0.75, Category = "Vegetable" }
            };
            return listProduct;
        }
    }
}
