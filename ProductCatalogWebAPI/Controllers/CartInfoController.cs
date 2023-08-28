using Microsoft.AspNetCore.Mvc;
using ProductCatalogWebAPI.Modules;
using ProductCatalogWebAPI.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductCatalogWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartInfoController : ControllerBase
    {
        // GET: api/<CartInfoController>
        [HttpGet]
        public IEnumerable<CartInfo> Get()
        {
            CartInfoRepository cartInfoRepo = new CartInfoRepository();
            return cartInfoRepo.GetCartInfo();
        }

        // GET api/<CartInfoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<CartInfoController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<CartInfoController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<CartInfoController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
