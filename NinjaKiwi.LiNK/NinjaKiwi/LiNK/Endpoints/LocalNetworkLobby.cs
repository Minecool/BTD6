namespace NinjaKiwi.LiNK.Endpoints;

public class LocalNetworkLobby
{
	private static readonly DateTime unixEpoch; //Field offset: 0x0
	public readonly string playerGlobalID; //Field offset: 0x10
	public readonly string id; //Field offset: 0x18
	public readonly string creatorName; //Field offset: 0x20
	public readonly DateTime createdAt; //Field offset: 0x28
	public readonly TimeSpan ageWhenFound; //Field offset: 0x30
	public readonly JObject metadata; //Field offset: 0x38

	private static LocalNetworkLobby() { }

	public LocalNetworkLobby(string playerGlobalID, string id, string displayName, long createdAt, long fromNow, JObject metadata) { }

}

