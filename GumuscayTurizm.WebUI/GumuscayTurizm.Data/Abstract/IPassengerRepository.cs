using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Abstract
{
    public interface IPassengerRepository : IRepository<Passenger>
    {
        int GetPassengerById(int id);
        Task CreateAsync(Passenger passenger);


    }
}
