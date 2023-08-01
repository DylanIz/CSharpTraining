﻿using AutoMapper;
using CityInfo.Api.Models;
using CityInfo.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/cities")]

    public class CitiesController : ControllerBase
    {
        private readonly ICityInfoRepository _cityInfoRepository;

        private readonly IMapper _mapper;

        public CitiesController(ICityInfoRepository cityInfoRepository,IMapper mapper)
        {
             _cityInfoRepository = cityInfoRepository ??
                throw new ArgumentNullException(nameof(cityInfoRepository));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
            
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityWithoutPointsOfInterestDto>>> GetCities(
            string? name, string? searchQuery)
        {
            var cityEntites = await _cityInfoRepository.GetCitiesAsync(name, searchQuery);

            return Ok(_mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntites));
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetCity
            (int id, bool includePointsOfInterest = false)
        {


            var city = await _cityInfoRepository.GetCityAsync(id, includePointsOfInterest);

            if(city == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest)
            {
                return Ok(_mapper.Map<CityDto>(city));
            }

            return Ok(_mapper.Map<CityWithoutPointsOfInterestDto>(city));

            //var cityToReturn = _citiesDataStore.Cities
            //    .FirstOrDefault(c => c.Id == id);
            //if (cityToReturn == null)
            //{
            //    return NotFound();
            //}

            //return Ok(cityToReturn);

        }


    }
}
