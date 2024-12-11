using AutoMapper;
using MacWebApi.Data.Models;
using MacWebApi.DTOs;
using MacWebApi.Services.CategoryServices;
using MacWebApi.Services.ProductServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace MacWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService productService;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            this.productService = productService;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        public IActionResult GetProducts()
        {
            var products = _mapper.Map<List<ProductDto>>(productService.GetProducts());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(products);
        }
        [HttpGet("{productId}")]
        [ProducesResponseType(200, Type = typeof(Product))]
        [ProducesResponseType(400)]
        public IActionResult GetProduct(int productId)
        {
            var product = productService.GetProduct(productId);
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(product);
        }

        [HttpGet("existsproducts")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        public IActionResult GetExistsProducts()
        {
            var products = productService.GetExistsProducts();
            if(!ModelState.IsValid) 
                return BadRequest(ModelState);  
            return Ok(products);    
        }
        [HttpGet("saleproducts")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        public IActionResult GetSaleProducts()
        {
            var products = productService.GetSaleProducts();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(products);
        }
        [HttpGet("exists/{productId}")]
        [ProducesResponseType(200, Type = typeof(bool))]
        [ProducesResponseType(400)]
        public IActionResult IsExist(int productId)
        {
            var res = productService.IsExist(productId);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(res);
        }
        [HttpGet("search/{name}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        public IActionResult Search(string name)
        {
            var products = productService.Search(name);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(products);
        }
    }
}
