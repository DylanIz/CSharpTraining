using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [ApiController]

    public class CitiesController : Controller
    {
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
