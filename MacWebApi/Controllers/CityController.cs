using AutoMapper;
using MacWebApi.Data.Models;
using MacWebApi.DTOs;
using MacWebApi.Services.CategoryServices;
using MacWebApi.Services.CityServices;
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
        [HttpGet("{cityId}")]
        [ProducesResponseType(200, Type = typeof(City))]
        [ProducesResponseType(400)]
        public IActionResult GetCity(int cityId)
        {
            var city = _mapper.Map<CityDto>(cityService.GetCity(cityId));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(city);
        }

    }
}
