using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Entity
{
    public class Bus
    {
        public int BusId { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
