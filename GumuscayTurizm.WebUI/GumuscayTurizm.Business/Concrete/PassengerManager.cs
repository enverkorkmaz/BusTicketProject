using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Concrete
{
    public class PassengerManager : IPassengerService
    {
        public Task CreateAsync(Passenger passenger)
        {
            throw new NotImplementedException();
        }

        public void Delete(Passenger passenger)
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

        public void Update(Passenger passenger)
        {
            throw new NotImplementedException();
        }
    }
}
