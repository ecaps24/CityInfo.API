using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public JsonResult GetCities()
        {
            var temp = new JsonResult((CitiesDataStore.Current.Cities))
            {
                StatusCode = 200
            };
            return temp;
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities
                .FirstOrDefault(c => c.Id == id);
            if (cityToReturn==null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
