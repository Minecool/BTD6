namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_VerifyIos : Payment_VerifyGeneric
{

	internal Payment_VerifyIos(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<IapVerification> Call(string receipt, string itemID = null, string liNKID = null, bool restoring = false, bool subscription = false, string currency = null, float price = 0, string nexusCreator = null) { }

	public Task<IapVerification> Call(string receipt, string itemID = null, string liNKID = null, bool restoring = false, bool subscription = false, string currency = null, float price = 0, IEnumerable<String> nexusCreators = null) { }

}

