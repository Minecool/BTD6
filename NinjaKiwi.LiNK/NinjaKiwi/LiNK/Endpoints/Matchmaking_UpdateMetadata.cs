namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_UpdateMetadata : Endpoint<JObject>
{

	internal Matchmaking_UpdateMetadata(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<JObject> Call(string lobbyID, string ownerID, string parameterName, IConvertible parameterValue) { }

	public Task<JObject> Call(string lobbyID, string ownerID, Dictionary<String, IConvertible> metadataToChange) { }

	protected virtual JObject Receive(string json) { }

}

