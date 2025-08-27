namespace NinjaKiwi.GUTS.Models.CT.BTD6;

public class ContestedTerritoryIslandTileRulesBase
{
	[CompilerGenerated]
	private readonly Random <Randomiser>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ContestedTerritoryGameSettings <GameSettings>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Dictionary<String, ContestedTerritoryTowerSetting> <TowerSettings>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly ContestedTerritoryMapSettings <MapSettings>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly ContestedTerritoryInjectedSettings <InjectedSettings>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly ContestedTerritoryGameType <GameType>k__BackingField; //Field offset: 0x38

	public ContestedTerritoryGameSettings GameSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ContestedTerritoryGameType GameType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public ContestedTerritoryInjectedSettings InjectedSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ContestedTerritoryMapSettings MapSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Random Randomiser
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Dictionary<String, ContestedTerritoryTowerSetting> TowerSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ContestedTerritoryIslandTileRulesBase(int tileRandomiserSeed, Dictionary<ContestedTerritoryGameType, ContestedTerritoryGameSettings> availableTileSettings, CtMapGenerationSettings mapGenerationSettings) { }

	[CompilerGenerated]
	public ContestedTerritoryGameSettings get_GameSettings() { }

	[CompilerGenerated]
	public ContestedTerritoryGameType get_GameType() { }

	[CompilerGenerated]
	public ContestedTerritoryInjectedSettings get_InjectedSettings() { }

	[CompilerGenerated]
	public ContestedTerritoryMapSettings get_MapSettings() { }

	[CompilerGenerated]
	public Random get_Randomiser() { }

	[CompilerGenerated]
	public Dictionary<String, ContestedTerritoryTowerSetting> get_TowerSettings() { }

}

