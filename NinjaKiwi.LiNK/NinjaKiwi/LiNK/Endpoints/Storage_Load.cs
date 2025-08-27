namespace NinjaKiwi.LiNK.Endpoints;

public class Storage_Load : Endpoint<StorageModel>
{

	internal Storage_Load(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<StorageModel> Call(string filename, string owner, bool metaOnly = true) { }

	private static void CheckEtag(string data, string etag) { }

	protected virtual StorageModel Receive(string json) { }

}

