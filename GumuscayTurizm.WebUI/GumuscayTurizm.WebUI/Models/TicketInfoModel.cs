using GumuscayTurizm.Entity;

namespace GumuscayTurizm.WebUI.Models
{
    public class TicketInfoModel
    {
        public string PassengerFirstName { get; set; }
        public string PassengerLastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int SeatNumber { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public Passenger Passenger { get; set; }
        public Ticket Ticket { get; set; }
        public City FromWhere { get; set; }
        public City ToWhere { get; set; }
        public int FromWhereId { get; set; }
        public int ToWhereId { get; set; }
        public List<City> Cities { get; set; }
        public decimal Price { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }
        public string EstimatedTime { get; set; }
    }
}
