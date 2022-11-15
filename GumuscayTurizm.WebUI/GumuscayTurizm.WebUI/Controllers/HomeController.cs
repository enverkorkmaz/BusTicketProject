using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Entity;
using GumuscayTurizm.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GumuscayTurizm.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IBusService _busService;
        private readonly IPassengerService _passengerService;
        private readonly ITicketService _ticketService;
        private readonly ITripService _tripService;

        public HomeController(ICityService cityService, IBusService busService, IPassengerService passengerService, ITicketService ticketService, ITripService tripService)
        {
            _cityService = cityService;
            _busService = busService;
            _passengerService = passengerService;
            _ticketService = ticketService;
            _tripService = tripService;
        }

        public async Task<IActionResult> Index()
        {
            var result  = await _cityService.GetAllAsync();
            HomePageModel homePageModel = new HomePageModel()
            {
                Cities = result
            };
            return View(homePageModel);
        }
        public async Task<IActionResult> TripList(HomePageModel homePageModel)
        {
            var result = await _tripService.GetTripsAsync(homePageModel.fromWhereId, homePageModel.toWhereId, homePageModel.Date);
            List<TripListModel> tripsModel = result.Select(t => new TripListModel
            {
                toWhereId = t.ToWhereId,
                fromWhereId = t.FromWhereId,
                toWhere = t.ToWhere,
                fromWhere = t.FromWhere,
                Price = t.Price,
                Date = t.Date,
                Time = t.Time

            }).ToList();
           
            return View(tripsModel);

        }
       
        public async Task<IActionResult> BuyTicket()
        {
            return View();
        }
        

       
    }
}