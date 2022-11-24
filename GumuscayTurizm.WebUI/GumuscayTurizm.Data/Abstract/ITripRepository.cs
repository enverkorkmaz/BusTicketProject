using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Abstract
{
    public interface ITripRepository : IRepository<Trip>
    {
        Task<List<Trip>> GetTripById(int id);
        Task<List<Trip>> GetTripsAsync(int fromWhereId, int toWhereId, DateTime Date);
        int GetSeatCapacity(int tripId);
        int GetBusId(int tripId);

    }
}
