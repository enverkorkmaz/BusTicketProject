using GumuscayTurizm.Entity;
using System.ComponentModel.DataAnnotations;

namespace GumuscayTurizm.WebUI.Models
{
    public class BuyTicketModel
    {
        public int PassengerId { get; set; }
        
        public int TripId { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        public string PassengerFirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        public string PassengerLastName { get; set; }
        public string PassengerGender { get; set; }
        [Required(ErrorMessage = "ID number is required.")]
        public string PassengerIdentificationNumber { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }
        public int SeatCapacity { get; set; }
        public Ticket Ticket { get; set; }
        public int TicketId { get; set; }
        [Required(ErrorMessage = "Please select seat.")]
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Card Holder Name  is required.")]
        public string CardHolderName { get; set; }
        [Required(ErrorMessage = "Card Number  is required.")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Expire Month  is required.")]
        public string ExpireMonth { get; set; }
        [Required(ErrorMessage = "Expire Year  is required.")]
        public string ExpireYear { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Cvc { get; set; }
        public string Phone { get; set; }
        

    }
}
