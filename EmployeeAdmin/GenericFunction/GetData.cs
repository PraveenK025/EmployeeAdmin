using EmployeeAdmin.Model;

namespace EmployeeAdmin.GenericFunction
{
    public class GetData
    {
        public static List<Products> GetProductList()
        {
            var listEmployees = new List<Products>
            {
                new Products { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" },
                new Products { Id = 2, Name = "Smartphone", Price = 699.99m, Category = "Electronics" },
                new Products { Id = 3, Name = "Desk Chair", Price = 149.99m, Category = "Furniture" },
            };

            return listEmployees;

        }

        public static List<EmployeeMapper> GetEmployeeData()
        {
            var listEmployees = new List<EmployeeMapper>()
            {
                new EmployeeMapper(){ Id = 1, Name = "Praveen", Age = 28,  Gender = "Male", Email = "Praveen@Example.com" },
                new EmployeeMapper(){ Id = 2, Name = "Kumar", Age = 30,  Gender = "Male", Email = "Kumar@Example.com" },
            };
            return listEmployees;
        }

        public static List<Product> GetProductData()
        {
            var listProducts = new List<Product>()
            {
                new Product { Id = 1001, Name="Laptop", Category="Electronics", Price = 1000, InStock = true},
                new Product { Id = 1002, Name="T-Shirt", Category="Merchandise", Price = 2000, InStock = false}
            };
            return listProducts;
        }
        public static List<Order> Getorders()
        {
            var listOrders = new List<Order>()
            {
                new Order { Id = 1001, CustomerName="Pranaya", TotalAmount = 1000},
                new Order { Id = 1002, CustomerName="Priyanka", TotalAmount = 2000}
            };
            return listOrders;
        }
        public static List<ProductData> GetProductDataList()
        {
            var listProducts = new List<ProductData>()
        {
            new ProductData { Id = 1001, Name="Laptop", Price = 1000, Quantity = 10, CreatedBy = "System", CreatedOn=DateTime.Now},
            new ProductData { Id = 1002, Name="Desktop", Price = 2000, Quantity = 20, CreatedBy = "System", CreatedOn=DateTime.Now}
        };
            return listProducts;
        }
    }
}
