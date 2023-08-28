using ProductCatalogWebAPI.Modules;
using System.Transactions;

namespace ProductCatalogWebAPI.Repository
{
    public class ProductRepository
    {
        List<Product> products = new() 
        { 
            new Product() { ProductId = 1234, ProductName = "TV", ProductCategory = "HA", ProductCategoryDescription = "Home Appliances - Big", ProductDescription = "LED TV 32 Inc", ProductPrice = 12000, ProductDiscountRate = 10, ProductInStock = true }
            , new Product() { ProductId = 1235, ProductName = "TV", ProductCategory = "HA", ProductCategoryDescription = "Home Appliances - Big", ProductDescription = "LED TV 43 Inc", ProductPrice = 24000, ProductDiscountRate = 8, ProductInStock = true }
            , new Product() { ProductId = 1236, ProductName = "Washing Machine", ProductCategory = "HA", ProductCategoryDescription = "Home Appliances - Big", ProductDescription = "Washing Machine 6.2KG", ProductPrice = 14000, ProductDiscountRate = 6, ProductInStock = true }
            , new Product() { ProductId = 1237, ProductName = "Washing Machine", ProductCategory = "HA", ProductCategoryDescription = "Home Appliances - Big", ProductDescription = "Washing Machine 7.2KG", ProductPrice = 18000, ProductDiscountRate = 6, ProductInStock = true }
        };

        //public ProductRepository(List<Product> products)
        //{
        //    this.products = products;
        //}

        public List<Product> GetProducts() { return products; }

        public Product GetProductById(int productId) 
        { 
            return products.Find(x => x.ProductId== productId);
        }
        public List<Product> GetProductByCategory(string category)
        {
            List<Product> pd = products.FindAll(x => x.ProductCategory== category);
            return pd;
        }

        public List<Product> GetProductInStock(bool inStock)
        {
            List<Product> pd = products.FindAll(x => x.ProductInStock == inStock);
            return pd;
        }

        public List<Product> DeleteProduct(int productId)
        {
            products.Remove(GetProductById(productId));
            return products;
        }

        public List<Product> AddProduct(Product product)
        {
            products.Add(product);
            return products;
        }
    }
}
