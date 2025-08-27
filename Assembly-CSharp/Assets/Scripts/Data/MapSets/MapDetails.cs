namespace Assets.Scripts.Data.MapSets;

public class MapDetails
{
	public string id; //Field offset: 0x10
	public MapDifficulty difficulty; //Field offset: 0x18
	public CoopDivision coopMapDivisionType; //Field offset: 0x1C
	public MapDifficulty unlockDifficulty; //Field offset: 0x20
	public string mapMusic; //Field offset: 0x28
	public SpriteReference mapSprite; //Field offset: 0x30
	public PrefabReference odysseyStatue; //Field offset: 0x38
	public bool isDebug; //Field offset: 0x40
	[SerializeField]
	private bool isBrowserOnly; //Field offset: 0x41
	public bool hasWater; //Field offset: 0x42
	public MapTheme theme; //Field offset: 0x44

	public bool IsBrowserOnly
	{
		 get { } //Length: 81
	}

	public bool IsStandard
	{
		 get { } //Length: 17
	}

	public MapDetails() { }

	public bool get_IsBrowserOnly() { }

	public bool get_IsStandard() { }

}

