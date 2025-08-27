namespace Assets.Scripts.Data.Legends;

public class RogueLootData
{
	public RogueLootType rogueLootType; //Field offset: 0x10
	public bool allowTowers; //Field offset: 0x14
	public bool allowArtifacts; //Field offset: 0x15
	public int artifactTierOverride; //Field offset: 0x18
	public int instaTierOverride; //Field offset: 0x1C
	public string bossType; //Field offset: 0x20
	public bool isTokenLoot; //Field offset: 0x28
	public int round; //Field offset: 0x2C
	public int repeats; //Field offset: 0x30
	public int tileSeed; //Field offset: 0x34
	public Nullable<Vector2Int> tileCoords; //Field offset: 0x38

	public RogueLootData() { }

}

