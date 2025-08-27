namespace Assets.Scripts.Data.Legends;

public class RogueTileSaveData
{
	public Vector2Int coords; //Field offset: 0x10
	public int height; //Field offset: 0x18
	public RogueTileType tileType; //Field offset: 0x1C
	public string tileID; //Field offset: 0x20
	public int propType; //Field offset: 0x28
	public bool shufflePosition; //Field offset: 0x2C
	public int seed; //Field offset: 0x30

	public RogueTileSaveData() { }

}

