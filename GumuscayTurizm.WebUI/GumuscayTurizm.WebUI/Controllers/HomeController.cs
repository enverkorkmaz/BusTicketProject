using GumuscayTurizm.Business.Abstract;
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

       
    }
}