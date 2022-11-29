using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GumuscayTurizm.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IBusService _busService;
        private readonly IPassengerService _passengerService;
        private readonly ITicketService _ticketService;
        private readonly ITripService _tripService;

        public AdminController(ICityService cityService, IBusService busService, IPassengerService passengerService, ITicketService ticketService, ITripService tripService)
        {
            _cityService = cityService;
            _busService = busService;
            _passengerService = passengerService;
            _ticketService = ticketService;
            _tripService = tripService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AdminTripList()
        {
            var trips = await _tripService.GetAllAsync();
            ViewBag.cities = await _cityService.GetAllAsync();
            return View(trips);
        }
        public async Task<IActionResult> TripEdit(int id)
        {
            var trip = await _tripService.GetByIdAsync(id);
            var cities = await _cityService.GetAllAsync();
            TripEditModel tripEditModel = new TripEditModel()
            {
                TripId = trip.TripId,
                ToWhere = trip.ToWhere,
                FromWhere = trip.FromWhere,
                Date = trip.Date,
                Time = trip.Time,
                Price = trip.Price,
                BusId = trip.BusId,
                ToWhereId = trip.ToWhereId,
                FromWhereId = trip.FromWhereId,
                Cities = cities
            };
            return View(tripEditModel);
        }
        [HttpPost]
        public async Task<IActionResult> TripEdit(TripEditModel tripEditModel)
        {
            if(ModelState.IsValid)
            {
                var trip = await _tripService.GetByIdAsync(tripEditModel.TripId);
                trip.ToWhere= tripEditModel.ToWhere;
                trip.FromWhere= tripEditModel.FromWhere;
                trip.Date = tripEditModel.Date;
                trip.Time = tripEditModel.Time;
                trip.Price = tripEditModel.Price;
                trip.ToWhereId= tripEditModel.ToWhereId;
                trip.FromWhereId = tripEditModel.FromWhereId;
                trip.BusId = tripEditModel.BusId;
                _tripService.Update(trip);
                return RedirectToAction("AdminTripList");
            }
            return View(tripEditModel);
        }

    }
}
