namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_Search : Endpoint<Response>
{
	[DataContract]
	internal class Response
	{
		[DataMember(Name = "total")]
		public int total; //Field offset: 0x10
		[DataMember(Name = "next")]
		public int next; //Field offset: 0x14
		[DataMember(Name = "found")]
		public int found; //Field offset: 0x18
		[DataMember(Name = "guilds")]
		public List<GuildModel> guilds; //Field offset: 0x20

		public Response() { }

	}


	internal Guild_Search(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Response> Call(string searchQuery, int limit, int offset) { }

}

