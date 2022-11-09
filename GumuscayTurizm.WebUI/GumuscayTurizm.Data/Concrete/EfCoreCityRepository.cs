using GumuscayTurizm.Data.Abstract;
using GumuscayTurizm.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Concrete
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City>, ICityRepository
    {
        public EfCoreCityRepository(GTContext _dbContext) : base(_dbContext)
            
        {

        }
        private GTContext context
        {
            get
            {
                return context as GTContext;
            }
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await context
                .Set<City>()
                .ToListAsync();
                
        }

        public Task<City> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetCitiesById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
