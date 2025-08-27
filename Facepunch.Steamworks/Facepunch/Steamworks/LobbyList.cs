namespace Facepunch.Steamworks;

public class LobbyList : IDisposable
{
	internal class Lobby
	{
		private Dictionary<String, String> lobbyData; //Field offset: 0x10
		internal Client Client; //Field offset: 0x18
		[CompilerGenerated]
		private string <Name>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private ulong <LobbyID>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private ulong <Owner>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private int <MemberLimit>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private int <NumMembers>k__BackingField; //Field offset: 0x3C
		[CompilerGenerated]
		private string <LobbyType>k__BackingField; //Field offset: 0x40

	}

	internal Client client; //Field offset: 0x10
	[CompilerGenerated]
	private List<Lobby> <Lobbies>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Finished>k__BackingField; //Field offset: 0x20
	internal List<UInt64> requests; //Field offset: 0x28
	public Action OnLobbiesUpdated; //Field offset: 0x30

	private List<Lobby> Lobbies
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal LobbyList(Client client) { }

	public override void Dispose() { }

	[CompilerGenerated]
	private void set_Lobbies(List<Lobby> value) { }

}

