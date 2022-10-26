using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Entity
{
    public class Route
    {
        public int RouteId { get; set; }
        public int FromWhereId { get; set; }
        public int ToWhereId { get; set; }
        public int? ParentRouteId { get; set; }
        public decimal Price { get; set; }
        public List<Trip> Trips { get; set; }
        public List<City> Cities { get; set; }

    }
}
