using GumuscayTurizm.Entity;

namespace GumuscayTurizm.WebUI.Models
{
    public class ShowTicketModel
    {
        public int TicketId { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public int SeatNumber { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }
    }
}
