namespace Assets.Scripts.Data.ContestedTerritory;

public class DecorativeTiles
{
	public string id; //Field offset: 0x10
	public ContestedTerritoryIslandTileTheme theme; //Field offset: 0x18
	public PrefabReference baseTile; //Field offset: 0x20
	public DecorativeTile[] decorations; //Field offset: 0x28

	public DecorativeTiles() { }

}

