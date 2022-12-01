using GumuscayTurizm.WebUI.Identity;
using GumuscayTurizm.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GumuscayTurizm.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<MyUser> _userManager;
        private readonly SignInManager<MyUser> _signInManager;

        public AccountController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                var myUser = new MyUser()
                {
                    FirstName = registerModel.FirstName,
                    LastName = registerModel.LastName,
                    UserName = registerModel.UserName,
                    Email = registerModel.Email
                };
                await _userManager.CreateAsync(myUser, registerModel.Password);
                
            }
            return View(registerModel);
        }
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginModel() { ReturnUrl = returnUrl });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var myUser = await _userManager.FindByEmailAsync(loginModel.Email);
                if (myUser == null)
                {
                    
                    return View(loginModel);
                }
                var result = await _signInManager.PasswordSignInAsync(myUser, loginModel.Password, loginModel.RememberMe, false);
                if (result.Succeeded)
                {
                    return Redirect(loginModel.ReturnUrl ?? "~/");
                }
                
                return View(loginModel);
            }
            return View(loginModel);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }


    }
}
