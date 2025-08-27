namespace Assets.Scripts.Models.MapEditorBehaviors;

public class MapEditorTowerDataModel : Model
{
	public TowerModel towerModel; //Field offset: 0x30
	public PositionalData positionalData; //Field offset: 0x38
	public bool isHero; //Field offset: 0x40
	public int maxHeroLevel; //Field offset: 0x44
	public int currentHeroLevel; //Field offset: 0x48
	public int path1NumBlockedTiers; //Field offset: 0x4C
	public int path2NumBlockedTiers; //Field offset: 0x50
	public int path3NumBlockedTiers; //Field offset: 0x54
	public int currPath1Tier; //Field offset: 0x58
	public int currPath2Tier; //Field offset: 0x5C
	public int currPath3Tier; //Field offset: 0x60
	public bool isNotSelectable; //Field offset: 0x64
	public bool isNotUpgradable; //Field offset: 0x65
	public bool isNotSellable; //Field offset: 0x66
	public bool disablePlacementOnLoad; //Field offset: 0x67
	public string targetType; //Field offset: 0x68
	public bool lockTargetTypeSwitching; //Field offset: 0x70

	public MapEditorTowerDataModel(string name, TowerModel towerModel, PositionalData positionalData, bool isHero, int maxHeroLevel, int currentHeroLevel, int path1NumBlockedTiers, int path2NumBlockedTiers, int path3NumBlockedTiers, int currPath1Tier, int currPath2Tier, int currPath3Tier, bool isNotSelectable, bool isNotUpgradable, bool isNotSellable, bool disablePlacementOnLoad, string targetType, bool lockTargetTypeSwitching) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

