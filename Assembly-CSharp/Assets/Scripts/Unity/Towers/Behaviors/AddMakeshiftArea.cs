namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AddMakeshiftArea : TowerBehavior
{
	public AddMakeshiftArea parent; //Field offset: 0x98
	public GameObject placeableAreaObject; //Field offset: 0xA0
	public AreaType areaType; //Field offset: 0xA8
	public string areaTypeString; //Field offset: 0xB0
	public string expAreaTypeString; //Field offset: 0xB8
	public string filterInTowerSizes; //Field offset: 0xC0
	public string expFilterInTowerSizes; //Field offset: 0xC8
	public string filterInTowerSets; //Field offset: 0xD0
	public string expFilterInTowerSets; //Field offset: 0xD8
	public string filterOutSpecificTowers; //Field offset: 0xE0
	public string expFilterOutSpecificTowers; //Field offset: 0xE8
	public float renderHeightOffset; //Field offset: 0xF0
	public string expRenderHeightOffset; //Field offset: 0xF8
	public bool ignoreZAxisTowerCollision; //Field offset: 0x100
	public string expIgnoreZAxisTowerCollision; //Field offset: 0x108
	public bool destroyTowersOnAreaWhenSold; //Field offset: 0x110
	public string expDestroyTowersOnAreaWhenSold; //Field offset: 0x118
	public bool dontDestroyTowersWhenAreaChanges; //Field offset: 0x120
	public string expDontDestroyTowersWhenAreaChanges; //Field offset: 0x128

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1099
	}

	public AddMakeshiftArea() { }

	public virtual TowerBehaviorModel get_Def() { }

}

