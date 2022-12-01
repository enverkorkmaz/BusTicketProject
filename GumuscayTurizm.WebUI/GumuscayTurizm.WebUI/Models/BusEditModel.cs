using GumuscayTurizm.Entity;

namespace GumuscayTurizm.WebUI.Models
{
    public class BusEditModel
    {
        public int BusId { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
