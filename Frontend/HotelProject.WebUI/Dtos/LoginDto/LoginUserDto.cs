using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
	public class LoginUserDto
	{
		[Required(ErrorMessage ="Kullanıcı Adını Girin")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Şifrenizi Girin")]
		public string Password { get; set; }
	}
}
