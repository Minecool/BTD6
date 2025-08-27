namespace Assets.Scripts.Data.ContestedTerritory;

public class MapGeneration
{
	public TileData[] functionalTiles; //Field offset: 0x10
	[Range(0, 1)]
	public float plainTileProportion; //Field offset: 0x18
	public DecorativeTiles[] decorativeTiles; //Field offset: 0x20

	public MapGeneration() { }

}

