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
    public class TripManager : ITripService
    {
        private ITripRepository _tripRepository;

        public TripManager(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

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

        public int GetSeatCapacity(int tripId)
        {
            return _tripRepository.GetSeatCapacity(tripId);
        }

        public async Task<List<Trip>> GetTripsAsync(int fromWhereId, int toWhereId, DateTime Date)
        {
            return await _tripRepository.GetTripsAsync(fromWhereId, toWhereId, Date);        
        }

        public void Update(Trip trip)
        {
            throw new NotImplementedException();
        }
    }
}
