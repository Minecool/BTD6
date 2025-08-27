namespace Facepunch.Steamworks;

public class SteamFriend
{
	[CompilerGenerated]
	private ulong <Id>k__BackingField; //Field offset: 0x10
	public string Name; //Field offset: 0x18
	[CompilerGenerated]
	private ulong <CurrentAppId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private uint <ServerIp>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <ServerGamePort>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private int <ServerQueryPort>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ulong <ServerLobbyId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Client <Client>k__BackingField; //Field offset: 0x40
	private PersonaState personaState; //Field offset: 0x48
	private FriendRelationship relationship; //Field offset: 0x4C

	internal Client Client
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal ulong CurrentAppId
	{
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal ulong Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal int ServerGamePort
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal uint ServerIp
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal ulong ServerLobbyId
	{
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal int ServerQueryPort
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public SteamFriend() { }

	[CompilerGenerated]
	internal Client get_Client() { }

	[CompilerGenerated]
	public ulong get_Id() { }

	public void Refresh() { }

	[CompilerGenerated]
	internal void set_Client(Client value) { }

	[CompilerGenerated]
	internal void set_CurrentAppId(ulong value) { }

	[CompilerGenerated]
	internal void set_Id(ulong value) { }

	[CompilerGenerated]
	internal void set_ServerGamePort(int value) { }

	[CompilerGenerated]
	internal void set_ServerIp(uint value) { }

	[CompilerGenerated]
	internal void set_ServerLobbyId(ulong value) { }

	[CompilerGenerated]
	internal void set_ServerQueryPort(int value) { }

}

