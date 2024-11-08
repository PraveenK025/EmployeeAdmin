using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Versioning.Comman;
using Versioning.Model;

namespace Versioning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        [HttpGet("GetV1")]
        [ApiVersion("1.0")]
        public IActionResult GetDataV1()
        {
            var listProducts = GetData.GetProductsV1();
            return Ok(listProducts);
        }

        [HttpGet("GetV2")]
        [ApiVersion("2.0")]
        public IActionResult GetDataV2()
        {
            var listProducts = GetData.GetProductsV2();
            return Ok(listProducts);
        }
    }
}
