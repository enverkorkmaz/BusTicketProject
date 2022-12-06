using GumuscayTurizm.Entity;
using System.ComponentModel.DataAnnotations;

namespace GumuscayTurizm.WebUI.Models
{
    public class BuyTicketModel
    {
        public int PassengerId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int TripId { get; set; }
        public string PassengerFirstName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string PassengerLastName { get; set; }
        public string PassengerGender { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string PassengerIdentificationNumber { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string Email { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }
        public int SeatCapacity { get; set; }
        public Ticket Ticket { get; set; }
        public int TicketId { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpireMonth { get; set; }
        public string ExpireYear { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Cvc { get; set; }
        public string Phone { get; set; }
        

    }
}
