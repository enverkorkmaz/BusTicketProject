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
        public string FromWhere { get; set; }
        public string ToWhere { get; set; }
        public string Station1 { get; set; }
        public string Station2 { get; set; }
        public string Station3 { get; set; }
    }
}
