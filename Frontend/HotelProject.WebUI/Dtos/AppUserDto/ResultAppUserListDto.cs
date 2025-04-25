namespace HotelProject.WebUI.Dtos.AppUserDto
{
	public class ResultAppUserListDto
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string? City { get; set; }  // gizlenebilir
		public string? ImageUrl { get; set; }
		public string? Country { get; set; }
		public string? Gender { get; set; }

	}
}
