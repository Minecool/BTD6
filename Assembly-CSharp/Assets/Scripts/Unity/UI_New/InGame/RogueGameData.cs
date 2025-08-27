namespace Assets.Scripts.Unity.UI_New.InGame;

public class RogueGameData
{
	public Vector2Int tileCoords; //Field offset: 0x10
	public RogueInstaMonkey[] instasInventory; //Field offset: 0x18
	public ArtifactLoot[] equippedArtifacts; //Field offset: 0x20
	public RogueTileType tileType; //Field offset: 0x28
	public BossType boss; //Field offset: 0x2C
	public RogueBloonModifier modifierType; //Field offset: 0x30
	public int stage; //Field offset: 0x34
	public RogueMiniGameData miniGameData; //Field offset: 0x38
	public bool isLegendaryTile; //Field offset: 0x40
	public int tileSeed; //Field offset: 0x44
	public bool isChimps; //Field offset: 0x48
	public bool isReverse; //Field offset: 0x49

	public RogueGameData(Vector2Int tileCoords, RogueInstaMonkey[] instasInventory, ArtifactLoot[] equippedArtifacts, RogueTileType tileType, BossType boss, int stage, RogueMiniGameData miniGameData, bool isLegendaryTile, int tileSeed, bool isChimps, RogueBloonModifier modifierType, bool isReverse) { }

	public RogueGameData Clone() { }

}

