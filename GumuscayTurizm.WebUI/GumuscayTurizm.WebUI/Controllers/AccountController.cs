using GumuscayTurizm.WebUI.Identity;
using GumuscayTurizm.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GumuscayTurizm.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                //login
            }
            return View(loginModel);
        }
        public  IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if(ModelState.IsValid)
            {
                User user = new User()
                {
                    Name = registerModel.Name,
                    Email = registerModel.Email,
                    UserName = registerModel.Username
                };
                var result = await _userManager.CreateAsync(user, registerModel.Password);
                if (result.Succeeded)
                {

                }
            }
            return View(registerModel);
        }
    }
}
