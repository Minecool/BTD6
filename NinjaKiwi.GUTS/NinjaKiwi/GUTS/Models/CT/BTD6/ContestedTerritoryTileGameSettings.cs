namespace NinjaKiwi.GUTS.Models.CT.BTD6;

public class ContestedTerritoryTileGameSettings
{
	public CtTileType tileType; //Field offset: 0x10
	public bool monkeyKnowledgeEnabled; //Field offset: 0x14
	public bool powersEnabled; //Field offset: 0x15
	public Dictionary<ContestedTerritoryGameType, ContestedTerritoryGameSettings> tileSettings; //Field offset: 0x18

	public ContestedTerritoryTileGameSettings() { }

}

