using Microsoft.AspNetCore.Identity;
namespace GumuscayTurizm.WebUI.Identity
{
    public class MyUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
