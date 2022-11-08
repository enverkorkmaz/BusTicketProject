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
        Trip GetTripById(int id);

    }
}
