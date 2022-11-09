using GumuscayTurizm.Data.Abstract;
using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Concrete
{
    public class EfCorePassengerRepository : EfCoreGenericRepository<Passenger>,IPassengerRepository
    {
        public EfCorePassengerRepository(GTContext _dbContext) : base(_dbContext)

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

        public Task CreateAsync(Passenger passenger)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Task<List<Passenger>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Passenger> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int GetPassengerById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
