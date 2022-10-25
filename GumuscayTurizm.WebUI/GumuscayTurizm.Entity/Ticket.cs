using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public int SeatNumber { get; set; }
    }
}
