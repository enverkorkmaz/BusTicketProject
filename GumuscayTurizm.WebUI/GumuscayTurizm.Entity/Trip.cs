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
        public string Date { get; set; }
        public string Time { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
    }
}
