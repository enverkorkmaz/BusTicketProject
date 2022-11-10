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

        public Task<List<Trip>> GetTripById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
