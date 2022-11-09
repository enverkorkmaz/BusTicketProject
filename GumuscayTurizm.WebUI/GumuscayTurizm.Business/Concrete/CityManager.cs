using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Data.Abstract;
using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Concrete
{
    public class CityManager : ICityService
    {
        private ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public Task CreateAsync(City city)
        {
            throw new NotImplementedException();
        }

        public void Delete(City city)
        {
            throw new NotImplementedException();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _cityRepository.GetAllAsync();
        }

        public Task<City> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(City city)
        {
            throw new NotImplementedException();
        }
    }
}
