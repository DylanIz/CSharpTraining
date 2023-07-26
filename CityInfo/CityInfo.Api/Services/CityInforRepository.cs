using CityInfo.Api.Entities;

namespace CityInfo.Api.Services
{
    public class CityInforRepository : ICityInfoRepository
    {
        public Task<IEnumerable<City>> GetCitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<City?> GetCityAsync(
            int cityId)
        {
            throw new NotImplementedException();
        }

        public Task<PointOfInterest?> GetPointOfInterestForCityAsync(
            int cityId, 
            int pointOfInterestId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCityAsync(
            int cityId)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<City>> ICityInfoRepository.GetCitiesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
