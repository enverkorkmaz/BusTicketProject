using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Abstract
{
    public interface IBusRepository : IRepository<Bus>
    {
        int SeatCapacity();
        string BusName();
    }
}
