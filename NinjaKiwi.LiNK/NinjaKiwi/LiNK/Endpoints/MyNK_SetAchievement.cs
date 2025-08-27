namespace NinjaKiwi.LiNK.Endpoints;

public class MyNK_SetAchievement : Endpoint<Response>
{
	[DataContract]
	internal class Response
	{
		[DataMember(Name = "achievedNow")]
		public bool achievedNow; //Field offset: 0x10

		public Response() { }

	}


	internal MyNK_SetAchievement(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Response> Call(string userID, int achievementID, string gameName, int percent) { }

	protected virtual Response Receive(string json) { }

}

