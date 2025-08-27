namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Find : Endpoint<Response>
{
	[DataContract]
	internal class Response
	{
		[DataMember(Name = "foundMatch")]
		public bool success; //Field offset: 0x10
		[DataMember(Name = "matchID")]
		public string lobbyID; //Field offset: 0x18

		public Response() { }

	}


	internal Matchmaking_Find(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Response> Call(IEnumerable<String> buckets, int maxPlayers) { }

	public Task<Response> Call(MatchMakingParameters parameters, string userID = null) { }

}

