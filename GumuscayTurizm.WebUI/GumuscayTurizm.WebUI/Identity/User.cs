using Microsoft.AspNetCore.Identity;
namespace GumuscayTurizm.WebUI.Identity
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}
