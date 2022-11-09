using GumuscayTurizm.Data.Abstract;
using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Concrete
{
    public class EfCoreTripRepository : EfCoreGenericRepository<Trip>,ITripRepository
    {
        public EfCoreTripRepository(GTContext _dbContext) : base(_dbContext)

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

        public Task<List<Trip>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Trip> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Trip>> GetTripById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
