using System.ComponentModel.DataAnnotations;

namespace GumuscayTurizm.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Kullanıcı adı giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Sifre giriniz")]
        public string Password { get; set; }
    }
}
