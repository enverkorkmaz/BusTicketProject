using GumuscayTurizm.Entity;

namespace GumuscayTurizm.WebUI.Models
{
    public class HomePageModel
    {
        public List<City> Cities { get; set; }
        public int fromWhereId { get; set; }
        public int toWhereId { get; set; }
        public DateTime Date { get; set; }
    }
}
