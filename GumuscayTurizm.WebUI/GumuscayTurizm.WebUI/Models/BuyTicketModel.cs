using GumuscayTurizm.Entity;
using System.ComponentModel.DataAnnotations;

namespace GumuscayTurizm.WebUI.Models
{
    public class BuyTicketModel
    {
        public int PassengerId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string PassengerFirstName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string PassengerLastName { get; set; }
        public string PassengerGender { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string PassengerIdentificationNumber { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string Email { get; set; }
        public Bus Bus { get; set; }
        public int SeatCapacity { get; set; }
        public Ticket Ticket { get; set; }
        public int SeatNo { get; set; }
    }
}
