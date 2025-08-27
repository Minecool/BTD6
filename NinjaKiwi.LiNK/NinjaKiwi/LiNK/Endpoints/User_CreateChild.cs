namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateChild : Endpoint<Response>
{
	internal class Response : LoginResponseModel
	{
		public string recoverCode; //Field offset: 0x20

		public Response() { }

	}


	internal User_CreateChild(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Response> Call() { }

}

