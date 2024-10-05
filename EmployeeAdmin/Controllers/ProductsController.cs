using AutoMapper;
using EmployeeAdmin.GenericFunction;
using EmployeeAdmin.Model;
using EmployeeAdmin.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;

namespace EmployeeAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ProductsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetProduct([FromRoute] int id)
        {
            var product = GetData.GetProductList().FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new { Message = "Product not found." });
            }
            return Ok(product);
        }


        [HttpGet]
        public IActionResult GetProducts([FromQuery] string category)
        {
            var filteredProducts = string.IsNullOrEmpty(category)
                ? GetData.GetProductList()
                : GetData.GetProductList().Where(p => p.Category == category).ToList();
            return Ok(filteredProducts);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Products product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            GetData.GetProductList().Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        [HttpGet("headers")]
        public IActionResult GetProductFromHeader([FromHeader(Name = "Product-Id")] int id)
        {
            var product = GetData.GetProductList().FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new { Message = "Product not found." });
            }
            return Ok(product);
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile([FromForm] Upload uploadFile)
        {
            IFormFile? file = uploadFile.File;

            if (file == null || file.Length == 0)
                return BadRequest("No file selected");

            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (string.IsNullOrEmpty(extension) ||
                (extension != ".pdf" && extension != ".png" && extension != ".jpg" && extension != ".jpeg"))
                return BadRequest("Invalid file type");

            var newFileName = Path.GetRandomFileName() + extension;

            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            var filePath = Path.Combine(folderPath, newFileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var fileUrl = Url.Content($"~/uploads/{newFileName}");
            return Ok(new { url = fileUrl });
        }

        [HttpGet("ContentNegotiation")]
        public ActionResult<List<Products>> GetProducts()
        {
            var listProducts = GetData.GetProductList();
            return Ok(listProducts);
        }


        [HttpGet("PreCondtionMapper")]
        public ActionResult<ProductDTO> GetProdcuts()
        {
            var productDTO = _mapper.Map<List<ProductDTO>>(GetData.GetProductData());
            return Ok(productDTO);
        }

        [HttpGet("PostCondtionMapper")]
        public ActionResult<ProductDTO> Getordrs()
        {
            var ordersDTO = _mapper.Map<List<OrderDTO>>(GetData.Getorders());
            return Ok(ordersDTO);
        }

        [HttpGet("FixDynamicMapper")]
        public ActionResult<ProductDTO> GetFixDynamicMapperData()
        {
            var products = _mapper.Map<List<ProductData>>(GetData.GetProductDataList());
            return Ok(products);
        }


    }
}
