using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/cities")]

    public class CitiesController : Controller
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1, Name = "Dublin" },
                    new { id = 2, Name = "Cork" }
                });
        }
    }
}
