using GumuscayTurizm.Entity;
using System.ComponentModel.DataAnnotations;

namespace GumuscayTurizm.WebUI.Models
{
    public class HomePageModel
    {
        public List<City> Cities { get; set; }
        [Required(ErrorMessage = "Please Select Departure City.")]
        public int fromWhereId { get; set; }
        [Required(ErrorMessage = "Please Select Arrival City.")]
        public int toWhereId { get; set; }
        [Required(ErrorMessage = "Please Select a Date.")]
        public DateTime Date { get; set; }
    }
}
