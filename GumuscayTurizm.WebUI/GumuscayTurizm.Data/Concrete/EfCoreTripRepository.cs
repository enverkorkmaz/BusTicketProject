using GumuscayTurizm.Data.Abstract;
using GumuscayTurizm.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
                return _dbContext as GTContext;
            }
        }

        public int GetBusId(int tripId)
        {
            int result = context
                .Trips
                .Where(t=>t.TripId== tripId)
                .Select(t=>t.BusId)
                .FirstOrDefault();
            return result;
        }

        public decimal GetPrice(int id)
        {
            var result = context
                .Trips
                .Where(t => t.TripId == id)
                .Select(t => t.Price)
                .FirstOrDefault();
            return result;
        }

        public int GetSeatCapacity(int tripId)
        {
            return context
            .Trips
            .Where(t => t.TripId == tripId)
            .Select(t => t.Bus.SeatingCapacity)
            .FirstOrDefault();
               
        }

        public Task<List<Trip>> GetTripById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Trip> GetTripByIdAsync(int id)
        {
            return await context
                .Trips
                .Where(t => t.TripId == id)
                .Include(t => t.FromWhere)
                .Include(t => t.ToWhere)
                .FirstOrDefaultAsync();
            
        }

        public async Task<List<Trip>> GetTripsAsync(int fromWhereId, int toWhereId, DateTime Date)
        {
            return await context
                .Trips
                .Where(t => t.FromWhereId == fromWhereId && t.ToWhereId == toWhereId && t.Date == Date)
                .Include(t => t.FromWhere)
                .Include(t => t.ToWhere)
                .ToListAsync();
        }
    }
}
