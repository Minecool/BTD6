namespace Assets.Scripts.Unity.Network;

public class CoopPlayerInfo
{
	public readonly PlayerInfo Info; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Player <LobbyPlayer>k__BackingField; //Field offset: 0x18
	public readonly byte PlayerNumber; //Field offset: 0x20

	public bool IsDisconnected
	{
		 get { } //Length: 73
	}

	public Player LobbyPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CoopPlayerInfo(Player player) { }

	public bool get_IsDisconnected() { }

	[CompilerGenerated]
	public Player get_LobbyPlayer() { }

}

