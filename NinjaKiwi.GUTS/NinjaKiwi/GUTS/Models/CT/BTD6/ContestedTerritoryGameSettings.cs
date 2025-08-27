namespace NinjaKiwi.GUTS.Models.CT.BTD6;

public class ContestedTerritoryGameSettings
{
	public float proportion; //Field offset: 0x10
	public CTGameSettingHeroes heroes; //Field offset: 0x18
	public CTGameSettingTowers towers; //Field offset: 0x20
	public CTGameSettingMapDifficulty mapDifficulty; //Field offset: 0x28
	public String[] mapBlacklist; //Field offset: 0x30
	public CTGameSettingGameDifficulty gameDifficulty; //Field offset: 0x38
	public CTGameSettingRounds rounds; //Field offset: 0x40
	public CTGameSettingBosses bosses; //Field offset: 0x48
	public Dictionary<ContestedTerritoryMapMode, Single> mapModeProportions; //Field offset: 0x50
	public CTGameSettingModifiers modifiers; //Field offset: 0x58
	public float noSellingFrequency; //Field offset: 0x60

	public ContestedTerritoryGameSettings() { }

}

