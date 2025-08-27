namespace NinjaKiwi.LiNK.Endpoints;

public class User_LinkGameCenterPlayerIDs : Endpoint<Boolean>
{

	internal User_LinkGameCenterPlayerIDs(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string oldID, string newID) { }

	protected virtual bool Receive(string json) { }

}

