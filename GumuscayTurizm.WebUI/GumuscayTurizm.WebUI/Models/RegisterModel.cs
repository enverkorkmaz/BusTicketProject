using System.ComponentModel.DataAnnotations;

namespace GumuscayTurizm.WebUI.Models
{
    public class RegisterModel
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı giriniz")]
        public string Username { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Sifre giriniz")]
        public string Password { get; set; }
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }
}
