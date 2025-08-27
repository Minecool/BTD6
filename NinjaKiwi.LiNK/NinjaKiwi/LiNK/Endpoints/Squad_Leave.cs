namespace NinjaKiwi.LiNK.Endpoints;

public class Squad_Leave : Endpoint<Response>
{
	[DataContract]
	internal class Response
	{
		[DataMember(Name = "success")]
		public bool success; //Field offset: 0x10
		[DataMember(Name = "reason")]
		public string reason; //Field offset: 0x18

		public Response() { }

	}


	internal Squad_Leave(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Response> Call() { }

}

