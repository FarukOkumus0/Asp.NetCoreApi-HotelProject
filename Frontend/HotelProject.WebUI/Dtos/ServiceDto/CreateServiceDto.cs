﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
	public class CreateServiceDto
	{
		[Required(ErrorMessage ="Hizmet ikon linki giriniz")]
		public string ServiceIcon { get; set; }
		[Required(ErrorMessage = "Hizmet başlığı giriniz")]
		[StringLength(100)]
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
