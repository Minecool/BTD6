namespace NinjaKiwi.LiNK.Lobbies;

public class ConnectionDetails
{
	public readonly string RelayHostName; //Field offset: 0x10
	public readonly int RelayPort; //Field offset: 0x18
	[JsonConverter(typeof(VersionConverter))]
	public readonly Version RelayBinaryVersion; //Field offset: 0x20
	public readonly string LobbyID; //Field offset: 0x28
	public readonly byte PlayerNumber; //Field offset: 0x30
	public readonly string PlayerGlobalID; //Field offset: 0x38

	[JsonConstructor]
	public ConnectionDetails(string relayHostName, int relayPort, Version relayBinaryVersion, string lobbyID, byte playerNumber, string playerGlobalID) { }

	public ConnectionDetails(ConnectionDetails toClone) { }

	public ConnectionDetails(LiNKLobby liNKLobby) { }

}

