namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_SteamStart : Endpoint<SteamOrderModel>
{

	internal Payment_SteamStart(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<SteamOrderModel> Call(string itemID, string itemDescription, string playerSteamID, string languageCode) { }

	protected virtual SteamOrderModel Receive(string json) { }

}

