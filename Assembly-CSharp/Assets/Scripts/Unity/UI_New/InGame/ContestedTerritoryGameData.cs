namespace Assets.Scripts.Unity.UI_New.InGame;

public class ContestedTerritoryGameData
{
	public static IReadOnlyCollection<Int32> DefaultCheckpointRounds; //Field offset: 0x0
	public SubGameType subGameType; //Field offset: 0x10
	public string selectedMode; //Field offset: 0x18
	public string selectedMap; //Field offset: 0x20
	public string selectedDifficulty; //Field offset: 0x28
	public DailyChallengeModel dcModel; //Field offset: 0x30
	public BossGameData bossData; //Field offset: 0x38

	private static ContestedTerritoryGameData() { }

	public ContestedTerritoryGameData(ContestedTerritoryTileGameSettings tileGameSettings) { }

}

