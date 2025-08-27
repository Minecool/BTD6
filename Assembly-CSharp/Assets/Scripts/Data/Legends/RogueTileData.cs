namespace Assets.Scripts.Data.Legends;

public class RogueTileData
{
	public Vector2Int coords; //Field offset: 0x10
	public RogueTileType tileType; //Field offset: 0x18
	public MapDetails map; //Field offset: 0x20
	public int propType; //Field offset: 0x28
	public int propRandomIndex; //Field offset: 0x2C
	public int height; //Field offset: 0x30
	public string id; //Field offset: 0x38
	public RogueMiniGameData minigameData; //Field offset: 0x40
	public BossType boss; //Field offset: 0x48
	public bool isLegendary; //Field offset: 0x4C
	public bool shufflePosition; //Field offset: 0x4D
	public int seed; //Field offset: 0x50
	public RogueBloonModifier modifier; //Field offset: 0x54
	public bool isReverse; //Field offset: 0x58

	public RogueTileData() { }

}

