using Newtonsoft.Json;


namespace HotelProject.WebUI.Dtos.FollowersDto
{
	//[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class ResultInstagramFollowersDto
	{
		//[JsonRequired]
		//[JsonProperty]
		//[JsonIgnore]
		public int? followers { get; set; }
		[JsonRequired]
		//[JsonProperty]
		//[JsonIgnore]
		public int? following { get; set; }
	}
}
