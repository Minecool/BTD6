namespace Assets.Scripts.Utils;

[IsReadOnly]
public struct CoopInvite
{
	public readonly string lobbyID; //Field offset: 0x0
	public readonly string playerName; //Field offset: 0x8

	public CoopInvite(string lobbyID, string playerName) { }

}

