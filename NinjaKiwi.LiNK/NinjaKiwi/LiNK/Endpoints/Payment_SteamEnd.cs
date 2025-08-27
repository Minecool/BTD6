namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_SteamEnd : Endpoint<SteamIapVerification>
{

	internal Payment_SteamEnd(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<SteamIapVerification> Call(string orderID, string itemID, string liNKID, string playerSteamID, string nexusCreator = null) { }

	public Task<SteamIapVerification> Call(string orderID, string itemID, string liNKID, string playerSteamID, IEnumerable<String> nexusCreators = null) { }

}

