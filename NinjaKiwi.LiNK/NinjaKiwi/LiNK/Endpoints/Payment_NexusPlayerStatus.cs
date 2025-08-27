namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_NexusPlayerStatus : Endpoint<NexusStatusModel>
{

	internal Payment_NexusPlayerStatus(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<NexusStatusModel> Call(string liNKID) { }

}

