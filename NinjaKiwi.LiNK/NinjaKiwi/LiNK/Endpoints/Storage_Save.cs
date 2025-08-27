namespace NinjaKiwi.LiNK.Endpoints;

public class Storage_Save : Endpoint<StorageModel>
{

	internal Storage_Save(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<StorageModel> Call(string filename, string data, string metadata = null, bool buffered = true, bool isPublic = true, bool compress = false, bool decode = false, bool reducedRedundancy = false, Nullable<TimeSpan> expiresIn = null, string render = "plain", string contentType = "text/plain", bool stephen = false) { }

	protected virtual StorageModel Receive(string json) { }

}

