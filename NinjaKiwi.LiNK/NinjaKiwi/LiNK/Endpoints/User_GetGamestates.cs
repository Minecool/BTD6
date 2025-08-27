namespace NinjaKiwi.LiNK.Endpoints;

public class User_GetGamestates : Endpoint<Dictionary`2<String, Int32>>
{

	internal User_GetGamestates(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Dictionary`2<String, Int32>> Call() { }

	protected virtual Dictionary<String, Int32> Receive(string json) { }

}

