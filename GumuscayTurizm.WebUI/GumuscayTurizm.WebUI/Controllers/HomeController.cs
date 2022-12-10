using GumuscatTurizm.Core;
using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Entity;
using GumuscayTurizm.WebUI.Models;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
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
            var result = await _cityService.GetAllAsync();
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
                TripId = t.TripId,
                toWhereId = t.ToWhereId,
                fromWhereId = t.FromWhereId,
                toWhere = t.ToWhere,
                fromWhere = t.FromWhere,
                Price = t.Price,
                Date = t.Date,
                Time = t.Time,
                EstimatedTime = t.EstimatedTime

            }).ToList();

            return View(tripsModel);

        }

        public async Task<IActionResult> BuyTicket(int tripId)
        {
            var result = _tripService.GetSeatCapacity(tripId);
            List<int> seats = new List<int>();
            for (int i = 1; i < result; i++)
            {
                seats.Add(i);
            }
            var result2 = _ticketService.GetSelectedSeats(tripId);
            foreach (var seat in result2)
            {
                seats.Remove(seat);
            }
            if (seats.Count() == 0)
            {
                ViewBag.FullBusErrorMessage = "This Bus is full";
            }
            ViewBag.AvailableSeats = seats;
            if (ModelState.IsValid)
            {
                BuyTicketModel buyTicketModel = new BuyTicketModel()
                {
                    SeatCapacity = _tripService.GetSeatCapacity(tripId),
                    TripId = tripId,
                    BusId = _tripService.GetBusId(tripId)

                };
                return View(buyTicketModel);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BuyTicket(BuyTicketModel buyTicketModel, int tripId)
        {
            if (ModelState.IsValid)
            {
                buyTicketModel.Price = _tripService.GetPrice(buyTicketModel.TripId);

                Options options = new Options();
                options.ApiKey = "sandbox-rJsPj6cwG5dIvQsoiHcswM3VUoi1cHry";
                options.SecretKey = "sandbox-oabdYTuookbU0zysfQcCZRu7sqfFu9Wz";
                options.BaseUrl = "https://sandbox-api.iyzipay.com";

                CreatePaymentRequest request = new CreatePaymentRequest();
                request.Locale = Locale.TR.ToString();
                request.ConversationId = "123456789";
                request.Price = buyTicketModel.Price.ToString().Replace(",", ".");
                request.PaidPrice = buyTicketModel.Price.ToString().Replace(",", ".");
                request.Currency = Currency.TRY.ToString();
                request.Installment = 1;
                request.BasketId = "B67832";
                request.PaymentChannel = PaymentChannel.WEB.ToString();
                request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

                PaymentCard paymentCard = new PaymentCard();
                paymentCard.CardHolderName = buyTicketModel.CardHolderName;
                paymentCard.CardNumber = buyTicketModel.CardNumber;
                paymentCard.ExpireMonth = buyTicketModel.ExpireMonth;
                paymentCard.ExpireYear = buyTicketModel.ExpireYear;
                paymentCard.Cvc = buyTicketModel.Cvc;
                paymentCard.RegisterCard = 0;
                request.PaymentCard = paymentCard;

                Buyer buyer = new Buyer();
                buyer.Id = "BY789";
                buyer.Name = buyTicketModel.PassengerFirstName;
                buyer.Surname = buyTicketModel.PassengerLastName;
                buyer.GsmNumber = "+905350000000";
                buyer.Email = buyTicketModel.Email;
                buyer.IdentityNumber = buyTicketModel.PassengerIdentificationNumber;
                buyer.LastLoginDate = "2015-10-05 12:43:35";
                buyer.RegistrationDate = "2013-04-21 15:12:09";
                buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
                buyer.Ip = "85.34.78.112";
                buyer.City = "Istanbul";
                buyer.Country = "Turkey";
                buyer.ZipCode = "34732";
                request.Buyer = buyer;

                Address shippingAddress = new Address();
                shippingAddress.ContactName = "Jane Doe";
                shippingAddress.City = "Istanbul";
                shippingAddress.Country = "Turkey";
                shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
                shippingAddress.ZipCode = "34742";
                request.ShippingAddress = shippingAddress;

                Address billingAddress = new Address();
                billingAddress.ContactName = "Jane Doe";
                billingAddress.City = "Istanbul";
                billingAddress.Country = "Turkey";
                billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
                billingAddress.ZipCode = "34742";
                request.BillingAddress = billingAddress;

                List<BasketItem> basketItems = new List<BasketItem>();
                BasketItem firstBasketItem = new BasketItem();
                firstBasketItem.Id = "BI101";
                firstBasketItem.Name = "Binocular";
                firstBasketItem.Category1 = "Collectibles";
                firstBasketItem.Category2 = "Accessories";
                firstBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                firstBasketItem.Price = buyTicketModel.Price.ToString().Replace(",", ".");
                basketItems.Add(firstBasketItem);
                request.BasketItems = basketItems;


                Payment payment = Payment.Create(request, options);


                if (payment.Status == "success")
                {
                    Passenger passenger = new Passenger()
                    {
                        FirstName = buyTicketModel.PassengerFirstName,
                        LastName = buyTicketModel.PassengerLastName,
                        IdentificationNumber = buyTicketModel.PassengerIdentificationNumber,
                        Email = buyTicketModel.Email

                    };


                    await _passengerService.CreateAsync(passenger);

                    Ticket ticket = new Ticket()
                    {
                        PassengerId = passenger.PassengerId,
                        SeatNumber = buyTicketModel.SeatNumber,
                        TripId = buyTicketModel.TripId,
                        BusId = buyTicketModel.BusId

                    };
                    await _ticketService.CreateAsync(ticket);
                    TempData["AlertMessage"] = Jobs.CreateMessage("Success!", "Your payment has been successfully received!", "success");
                    return RedirectToAction("TicketInfo",buyTicketModel);
                }
                TempData["AlertMessage"] = Jobs.CreateMessage("Unsuccessful!", payment.ErrorMessage, "danger");
            }
            var result = _tripService.GetSeatCapacity(tripId);
            List<int> seats = new List<int>();
            for (int i = 1; i < result; i++)
            {
                seats.Add(i);
            }
            var result2 = _ticketService.GetSelectedSeats(tripId);
            foreach (var seat in result2)
            {
                seats.Remove(seat);
            }
            if (seats.Count() == 0)
            {
                ViewBag.FullBusErrorMessage = "This Bus is full";
            }
            ViewBag.AvailableSeats = seats;

            return View("BuyTicket",buyTicketModel);


        }
        public async Task<IActionResult> TicketInfo(TicketInfoModel ticketInfoModel)
        {
            var trip = await _tripService.GetTripByIdAsync(ticketInfoModel.TripId);
            TicketInfoModel ticketDetails = new TicketInfoModel()
            {
                PassengerFirstName = ticketInfoModel.PassengerFirstName,
                PassengerLastName = ticketInfoModel.PassengerLastName,
                Email = ticketInfoModel.Email,
                PhoneNumber = ticketInfoModel.PhoneNumber,
                SeatNumber = ticketInfoModel.SeatNumber,
                Date = trip.Date,
                Time = trip.Time,
                FromWhereId = ticketInfoModel.FromWhereId,
                ToWhereId = ticketInfoModel.ToWhereId,
                FromWhere = trip.FromWhere,
                ToWhere = trip.ToWhere,
                Price = ticketInfoModel.Price,
                EstimatedTime = ticketInfoModel.EstimatedTime

            };
            return View(ticketDetails);
        }


    }
}