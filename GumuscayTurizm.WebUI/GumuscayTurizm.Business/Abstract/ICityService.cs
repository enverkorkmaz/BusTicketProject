using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Abstract
{
    public interface ICityService
    {
        Task<City> GetByIdAsync(int id);
        Task<List<City>> GetAllAsync();
        Task CreateAsync(City city);
        void Update(City city);
        void Delete(City city);
    }
}
