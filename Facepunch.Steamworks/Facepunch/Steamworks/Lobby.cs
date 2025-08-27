namespace Facepunch.Steamworks;

public class Lobby
{
	internal class LobbyData
	{
		internal Client client; //Field offset: 0x10
		internal ulong lobby; //Field offset: 0x18
		internal Dictionary<String, String> data; //Field offset: 0x20

	}

	internal enum MemberStateChange
	{
		Entered = 1,
		Left = 2,
		Disconnected = 4,
		Kicked = 8,
		Banned = 16,
	}

	internal enum Type
	{
		Private = 0,
		FriendsOnly = 1,
		Public = 2,
		Invisible = 3,
		Error = 4,
	}

	private static Byte[] chatMessageData; //Field offset: 0x0
	internal Client client; //Field offset: 0x10
	[CompilerGenerated]
	private ulong <CurrentLobby>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private LobbyData <CurrentLobbyData>k__BackingField; //Field offset: 0x20
	public Action<Boolean> OnLobbyJoined; //Field offset: 0x28
	internal Type createdLobbyType; //Field offset: 0x30
	public Action<Boolean> OnLobbyCreated; //Field offset: 0x38
	public Action OnLobbyDataUpdated; //Field offset: 0x40
	public Action<UInt64> OnLobbyMemberDataUpdated; //Field offset: 0x48
	public Action<UInt64, Byte[], Int32> OnChatMessageRecieved; //Field offset: 0x50
	public Action<UInt64, String> OnChatStringRecieved; //Field offset: 0x58
	public Action<MemberStateChange, UInt64, UInt64> OnLobbyStateChanged; //Field offset: 0x60
	public Action<UInt64, UInt64> OnUserInvitedToLobby; //Field offset: 0x68
	public Action<UInt64> OnLobbyJoinRequested; //Field offset: 0x70

	private static Lobby() { }

}

