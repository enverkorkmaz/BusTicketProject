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

        public async Task CreateAsync(Trip trip)
        {
            await _tripRepository.CreateAsync(trip);
        }

        public void Delete(Trip trip)
        {
            _tripRepository.Delete(trip);
        }

        public Task<List<Trip>> GetAllAsync()
        {
            return _tripRepository.GetAllAsync();
        }

        public int GetBusId(int tripId)
        {
            return _tripRepository.GetBusId(tripId);
        }

        public Task<Trip> GetByIdAsync(int id)
        {
            return _tripRepository.GetByIdAsync(id);
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
             _tripRepository.Update(trip);
        }
    }
}
