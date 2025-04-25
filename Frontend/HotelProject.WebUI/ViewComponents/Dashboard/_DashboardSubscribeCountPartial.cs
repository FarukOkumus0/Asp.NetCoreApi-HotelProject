using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	//[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]

	public class _DashboardSubscribeCountPartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			//List<ResultInstagramFollowersDto> resultInstagramFollowersDtos = new List<ResultInstagramFollowersDto>();

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/ozzakyol"),
				Headers =
	{
		{ "x-rapidapi-key", "9a56d4c150msh1a6ed5acf28bd01p113613jsnaddef83bd166" },
		{ "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				//resultInstagramFollowersDtos = JsonConvert.DeserializeObject<IDictionary<string, ResultInstagramFollowersDto>(body);
				ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
				ViewBag.v1 = resultInstagramFollowersDtos.followers;
				ViewBag.v2 = resultInstagramFollowersDtos.following;

			}


			var client2 = new HttpClient();
			var request2 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=ozzakyol"),
				Headers =
	{
		{ "x-rapidapi-key", "9a56d4c150msh1a6ed5acf28bd01p113613jsnaddef83bd166" },
		{ "x-rapidapi-host", "twitter32.p.rapidapi.com" },
	},
			};
			using (var response2 = await client2.SendAsync(request2))
			{
				response2.EnsureSuccessStatusCode();
				var body2 = await response2.Content.ReadAsStringAsync();
				ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
				ViewBag.v3 = resultTwitterFollowersDto.data.user_info.followers_count;
				ViewBag.v4 = resultTwitterFollowersDto.data.user_info.friends_count;

			}


			var client3 = new HttpClient();
			var request3 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://linkedin-api-live-data1.p.rapidapi.com/enrichment/profile?linkedInUrl=https%3A%2F%2Ftr.linkedin.com%2Fin%2Fozan-akyol-797a9594"),
				Headers =
	{
		{ "x-rapidapi-key", "9a56d4c150msh1a6ed5acf28bd01p113613jsnaddef83bd166" },
		{ "x-rapidapi-host", "linkedin-api-live-data1.p.rapidapi.com" },
	},
			};
			using (var response3 = await client3.SendAsync(request3))
			{
				response3.EnsureSuccessStatusCode();
				var body3 = await response3.Content.ReadAsStringAsync();
				ResultLinkedinFollowersDto resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
				ViewBag.v5 = resultLinkedinFollowersDto.person.followerCount;
			}


			return View();

		}
	}
}
