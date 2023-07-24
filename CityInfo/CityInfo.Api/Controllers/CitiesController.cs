﻿using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/cities")]

    public class CitiesController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]

        public ActionResult<CityDto> GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities
                .FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);

        }


    }
}