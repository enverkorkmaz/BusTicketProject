using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Abstract
{
    public interface ITripService
    {
        Task<Trip> GetByIdAsync(int id);
        Task<List<Trip>> GetAllAsync();
        Task CreateAsync(Trip trip);
        void Update(Trip trip);
        void Delete(Trip trip);
    }
}
