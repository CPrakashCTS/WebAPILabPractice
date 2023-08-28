using Microsoft.AspNetCore.Mvc;
using ProductCatalogWebAPI.Modules;
using ProductCatalogWebAPI.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductCatalogWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            ProductRepository productRepo = new ProductRepository();
            return productRepo.GetProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            ProductRepository productRepo = new ProductRepository();
            Product prod = productRepo.GetProductById(id);
            return (prod.ProductName + " - " + prod.ProductDescription + " - " + prod.ProductName + " - " + prod.ProductCategory + " - " + prod.ProductPrice + " - " + prod.ProductDiscountRate + " - " + prod.ProductInStock);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            ProductRepository productRepo = new ProductRepository();
            productRepo.AddProduct(new Product { ProductName = value.ProductName, ProductId = value.ProductId, ProductCategory = value.ProductCategory, ProductCategoryDescription = value.ProductCategoryDescription, ProductDescription = value.ProductDescription, ProductPrice = value.ProductPrice, ProductDiscountRate = value.ProductDiscountRate, ProductInStock = value.ProductInStock });
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            ProductRepository productRepo = new ProductRepository();
            return productRepo.DeleteProduct(id);
        }
    }
}
