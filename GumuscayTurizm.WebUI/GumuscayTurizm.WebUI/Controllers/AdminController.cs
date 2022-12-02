using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Entity;
using GumuscayTurizm.WebUI.Identity;
using GumuscayTurizm.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GumuscayTurizm.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IBusService _busService;
        private readonly IPassengerService _passengerService;
        private readonly ITicketService _ticketService;
        private readonly ITripService _tripService;
        private readonly UserManager<MyIdentityUser> _userManager;
        private readonly SignInManager<MyIdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(ICityService cityService, IBusService busService, IPassengerService passengerService, ITicketService ticketService, ITripService tripService, UserManager<MyIdentityUser> userManager, SignInManager<MyIdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _cityService = cityService;
            _busService = busService;
            _passengerService = passengerService;
            _ticketService = ticketService;
            _tripService = tripService;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        #region Trip
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

        public async Task<IActionResult> TripCreate()
        {
            //var trip = await _tripService.GetByIdAsync(id);
            var cities = await _cityService.GetAllAsync();
            TripCreateModel tripCreateModel = new TripCreateModel()
            {
                Cities = cities
            };
            return View(tripCreateModel);
        }
        [HttpPost]
        public async Task<IActionResult> TripCreate(TripCreateModel tripCreateModel)
        {
            if (ModelState.IsValid)
            {
                Trip trip = new Trip()
                {
                    ToWhere = tripCreateModel.ToWhere,
                    FromWhere = tripCreateModel.FromWhere,
                    Date = tripCreateModel.Date,
                    Time = tripCreateModel.Time,
                    Price = tripCreateModel.Price,
                    ToWhereId = tripCreateModel.ToWhereId,
                    FromWhereId = tripCreateModel.FromWhereId,
                    BusId = tripCreateModel.BusId,

                };

                await _tripService.CreateAsync(trip);
                return RedirectToAction("AdminTripList");
            }
            return View(tripCreateModel);
        }
        public async Task<IActionResult> TripDelete(int id)
        {
            var trip = await _tripService.GetByIdAsync(id);
            _tripService.Delete(trip);
            return RedirectToAction("AdminTripList");
        }
        #endregion

        #region Bus
        public async Task<IActionResult> BusList()
        {
            var buses = await _busService.GetAllAsync();
            return View(buses);
        }

        public async Task<IActionResult> BusEdit(int id)
        {
            var bus = await _busService.GetByIdAsync(id);
            BusEditModel busEditModel = new BusEditModel()
            {
                BusId = bus.BusId,
                Name = bus.Name,
                SeatingCapacity = bus.SeatingCapacity
            };
            return View(busEditModel);
        }
        [HttpPost]
        public async Task<IActionResult> BusEdit(BusEditModel busEditModel)
        {
            if (ModelState.IsValid)
            {
                var bus = await _busService.GetByIdAsync(busEditModel.BusId);
                bus.Name = busEditModel.Name;
                bus.SeatingCapacity = busEditModel.SeatingCapacity;
                _busService.Update(bus);
                return RedirectToAction("BusList");
            }
            return View(busEditModel);
        }

        public async Task<IActionResult> BusCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BusCreate(BusCreateModel busCreateModel)
        {
            if (ModelState.IsValid)
            {
                Bus bus = new Bus()
                {
                    Name = busCreateModel.Name,
                    SeatingCapacity = busCreateModel.SeatingCapacity
                };

                await _busService.CreateAsync(bus);
                return RedirectToAction("BusList");
            }
            return View(busCreateModel);
        }
        public async Task<IActionResult> BusDelete(int id)
        {
            var bus = await _busService.GetByIdAsync(id);
            _busService.Delete(bus);
            return RedirectToAction("BusList");
        }
        #endregion

        #region City
        public async Task<IActionResult> CityList()
        {
            var cities = await _cityService.GetAllAsync();
            return View(cities);
        }

        public async Task<IActionResult> CityEdit(int id)
        {
            var city = await _cityService.GetByIdAsync(id);
            CityEditModel cityEditModel = new CityEditModel()
            {
                CityId = city.CityId,
                Name = city.Name
            };
            return View(cityEditModel);
        }
        [HttpPost]
        public async Task<IActionResult> CityEdit(CityEditModel cityEditModel)
        {
            if (ModelState.IsValid)
            {
                var city = await _cityService.GetByIdAsync(cityEditModel.CityId);
                city.Name = cityEditModel.Name;
                _cityService.Update(city);
                return RedirectToAction("CityList");
            }
            return View(cityEditModel);
        }

        public async Task<IActionResult> CityCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CityCreate(CityCreateModel cityCreateModel)
        {
            if (ModelState.IsValid)
            {
                City city = new City()
                {
                    Name = cityCreateModel.Name
                };

                await _cityService.CreateAsync(city);
                return RedirectToAction("CityList");
            }
            return View(cityCreateModel);
        }

        public async Task<IActionResult> CityDelete(int id)
        {
            var city = await _cityService.GetByIdAsync(id);
            _cityService.Delete(city);
            return RedirectToAction("CityList");
        }
        #endregion

        #region User
        public async Task<IActionResult> UserList()
        {
            return View(await _userManager.Users.ToListAsync());
        }
        public async Task<IActionResult> UserCreate()
        {
            var roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            ViewBag.Roles = roles;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserCreate(UserModel userModel, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                MyIdentityUser user = new MyIdentityUser()
                {
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    UserName = userModel.UserName,
                    Email = userModel.Email
                };
                var result = await _userManager.CreateAsync(user, "Qwe123.");
                if (result.Succeeded)
                {
                    selectedRoles = selectedRoles ?? new string[] { };
                    await _userManager.AddToRolesAsync(user, selectedRoles);
                    return RedirectToAction("UserList");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            ViewBag.SelectedRoles = selectedRoles;
            ViewBag.Roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            return View(userModel);
        }
        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) { return RedirectToAction("UserList"); }
            var userModel = new UserModel()
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                SelectedRoles = await _userManager.GetRolesAsync(user)
            };
            ViewBag.Roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            return View(userModel);
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(userModel.UserId);
                if (user != null)
                {
                    user.FirstName = userModel.FirstName;
                    user.LastName = userModel.LastName;
                    user.UserName = userModel.UserName;
                    user.Email = userModel.Email;
                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        userModel.SelectedRoles = userModel.SelectedRoles ?? new string[] { };
                        await _userManager.AddToRolesAsync(user, userModel.SelectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user, userRoles.Except(userModel.SelectedRoles).ToArray<string>());
                        return RedirectToAction("UserList");

                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    ViewBag.Roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
                    return View(userModel);
                }
    
            }
            ViewBag.Roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            return View(userModel);
        }
        
        public async Task<IActionResult> ChangeUserPassword(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            ChangePasswordModel changePasswordModel = new ChangePasswordModel() { UserId = user.Id };
            return View(changePasswordModel);
        }
        [HttpPost]
        public async Task<IActionResult> ChangeUserPassword(ChangePasswordModel changePasswordModel)
        {
            var user = await _userManager.FindByIdAsync(changePasswordModel.UserId);
            var userPassToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, userPassToken, changePasswordModel.NewPassword);
            if (result.Succeeded)
            {
               
                return RedirectToAction("UserList");
            }
            return View(changePasswordModel);

        }

        #endregion
      
        #region Role
        public async Task<IActionResult> RoleList()
        {
            return View(await _roleManager.Roles.ToListAsync());
        }
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel roleModel)
        {
            if (ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole() { Name = roleModel.Name };
                var result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {

                    return RedirectToAction("RoleList");
                }
            }
            return View(roleModel);
        }
        public async Task<IActionResult> RoleEdit(string id)
        {
            var users = await _userManager.Users.ToListAsync();
            var role = await _roleManager.FindByIdAsync(id);
            var members = new List<MyIdentityUser>();
            var nonMembers = new List<MyIdentityUser>();
            foreach (var user in users)
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
               
            }
            RoleDetails roleDetails = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(roleDetails);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel roleEditModel)
        {
            if (ModelState.IsValid)
            {
                
                foreach (var userId in roleEditModel.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, roleEditModel.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }

                
                foreach (var userId in roleEditModel.IdsToRemove ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, roleEditModel.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }

            }
            return Redirect($"/Admin/RoleEdit/{roleEditModel.RoleId}");
        }

        public async Task<IActionResult> RoleDelete(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) { return NotFound(); }
            foreach (var user in await _userManager.Users.ToListAsync())
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                   
                    return RedirectToAction("RoleList");
                }
            }
            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {

            }
            return RedirectToAction("RoleList");
        }

        #endregion

        
    }
}
