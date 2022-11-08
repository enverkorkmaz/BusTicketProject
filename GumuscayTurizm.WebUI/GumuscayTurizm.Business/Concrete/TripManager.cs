using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Concrete
{
    public class TripManager : ITripService
    {
        public Task CreateAsync(Trip trip)
        {
            throw new NotImplementedException();
        }

        public void Delete(Trip trip)
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

        public void Update(Trip trip)
        {
            throw new NotImplementedException();
        }
    }
}
