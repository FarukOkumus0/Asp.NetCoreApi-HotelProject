namespace HotelProject.WebUI.Dtos.FollowersDto
{
	public class ResultLinkedinFollowersDto
	{


		public Person person { get; set; }


		public class Person
		{
			public int followerCount { get; set; }

		}
	}
}

