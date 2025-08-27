namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopLobbyData
{
	public LobbyConnection lobbyConnection; //Field offset: 0x10
	public CoopGameType coopGameType; //Field offset: 0x18
	public bool coopGameTypeLocked; //Field offset: 0x19
	public string challengeId; //Field offset: 0x20
	public bool quickMatch; //Field offset: 0x28
	public BossChallengeMenuData bossChallengeMenuData; //Field offset: 0x30

	public CoopLobbyData() { }

}

