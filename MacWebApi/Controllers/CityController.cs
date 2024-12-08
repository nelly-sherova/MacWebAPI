using AutoMapper;
using MacWebApi.Data.Models;
using MacWebApi.DTOs;
using MacWebApi.Interfaces;
using MacWebApi.Services.Category;
using MacWebApi.Services.City;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MacWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICityService cityService;
        public CityController(ICityService cityService, IMapper mapper)
        {
            this.cityService = cityService;
            this._mapper = mapper;  
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<City>))]
        public IActionResult GetCities()
        {
            var cities = _mapper.Map<List<CityDto>>(cityService.GetCities());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(cities);
        }

    }
}
