using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
	public class UpdateServiceDto
	{
		public int ServiceID { get; set; }

		[Required(ErrorMessage = "Hizmet ikon linki giriniz")]
		public string ServiceIcon { get; set; }
		[Required(ErrorMessage = "Hizmet başlığı giriniz")]
		[StringLength(100, ErrorMessage ="En fazla 100 karakter")]
		public string Title { get; set; }
		[Required(ErrorMessage = "Hizmet açıklaması giriniz")]
		[StringLength(250, ErrorMessage = "En fazla 250 karakter")]
		public string Description { get; set; }
	}
}
