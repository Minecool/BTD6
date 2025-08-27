namespace Assets.Scripts.Unity.Network;

public class Btd6LobbyParameters
{
	public readonly string Difficulty; //Field offset: 0x10
	public readonly string Map; //Field offset: 0x18
	public readonly string Mode; //Field offset: 0x20
	public readonly MapDifficulty MapDifficulty; //Field offset: 0x28
	public readonly string CreatorId; //Field offset: 0x30

	public Btd6LobbyParameters(string difficulty, string map, string mode, MapDifficulty mapDifficulty, string creatorId) { }

}

