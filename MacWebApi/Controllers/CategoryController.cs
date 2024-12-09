using AutoMapper;
using MacWebApi.Data.Models;
using MacWebApi.DTOs;
using MacWebApi.Services.CategoryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MacWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService; 

        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        public IActionResult GetCategories()
        {
            var categories = _mapper.Map<List<CategoryDto>>(_categoryService.GetCategories());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(categories);
        }

        [HttpGet("{categoryId}")]
        [ProducesResponseType(200, Type = typeof(Category))]
        [ProducesResponseType(400)]
        public IActionResult GetCategory(int categoryId)
        {
            var category = _mapper.Map<CategoryDto>(_categoryService.GetCategory(categoryId));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(category);
        }
        [HttpGet("byname/{categoryName}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        public IActionResult GetCategoriesByName(string categoryName)
        {
            var categories = _mapper.Map<List<Category>>(_categoryService.GetCategoriesNyName(categoryName));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(categories);
        }
    }
}
