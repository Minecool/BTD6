namespace Assets.Scripts.Models.ContentBrowser;

public class MapEditorTowerData : ICloneable<MapEditorTowerData>
{
	public string id; //Field offset: 0x10
	public PositionalData positionalData; //Field offset: 0x18
	public bool isHero; //Field offset: 0x20
	public int maxHeroLevel; //Field offset: 0x24
	public int currentHeroLevel; //Field offset: 0x28
	public int path1NumBlockedTiers; //Field offset: 0x2C
	public int path2NumBlockedTiers; //Field offset: 0x30
	public int path3NumBlockedTiers; //Field offset: 0x34
	public int currPath1Tier; //Field offset: 0x38
	public int currPath2Tier; //Field offset: 0x3C
	public int currPath3Tier; //Field offset: 0x40
	public bool disablePlacementOnLoad; //Field offset: 0x44
	public bool isNotSelectable; //Field offset: 0x45
	public bool isNotUpgradable; //Field offset: 0x46
	public bool isNotSellable; //Field offset: 0x47
	public string targetType; //Field offset: 0x48
	public bool lockTargetTypeSwitching; //Field offset: 0x50

	public MapEditorTowerData() { }

	[CompilerGenerated]
	private bool <Def>b__19_0(TowerModel x) { }

	[CompilerGenerated]
	private bool <Def>b__19_1(PowerModel x) { }

	public override MapEditorTowerData Clone() { }

	public bool Compare(MapEditorTowerData com) { }

	public MapEditorTowerDataModel Def() { }

	private MapEditorTowerDataModel GetDataModel(TowerModel towerModel) { }

}

