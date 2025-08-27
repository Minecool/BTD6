namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_VerifyGeneric : Endpoint<IapVerification>
{

	internal Payment_VerifyGeneric(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	internal Task<IapVerification> Call(string endpoint, string receipt, string signature = null, string itemID = null, string identifier = null, bool restoring = false, bool subscription = false, string currency = null, float price = 0, IEnumerable<String> nexusCreators = null) { }

	protected virtual IapVerification Receive(string json) { }

}

