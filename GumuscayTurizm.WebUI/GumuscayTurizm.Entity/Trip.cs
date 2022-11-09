using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Entity
{
    public class Trip
    {
        public int TripId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        
        public int FromWhereId { get; set; }
        public int ToWhereId { get; set; }
        public decimal Price { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<City> Cities { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }
    }
}
