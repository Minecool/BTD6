namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AddMakeshiftArea), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddMakeshiftAreaModel : TowerBehaviorModel
{
	public Vector3[] points; //Field offset: 0x30
	public AreaType newAreaType; //Field offset: 0x38
	public String[] filterInTowerSizes; //Field offset: 0x40
	public TowerSet[] filterInTowerSets; //Field offset: 0x48
	public String[] filterOutSpecificTowers; //Field offset: 0x50
	public float renderHeightOffset; //Field offset: 0x58
	public bool ignoreZAxisTowerCollision; //Field offset: 0x5C
	public bool destroyTowersOnAreaWhenSold; //Field offset: 0x5D
	public bool dontDestroyTowersWhenAreaChanges; //Field offset: 0x5E

	public AddMakeshiftAreaModel(string name, Vector3[] points, AreaType newAreaType, String[] filterInTowerSizes, float renderHeightOffset, bool ignoreZAxisTowerCollision = false, String[] filterOutSpecificTowers = null, bool destroyTowersOnAreaWhenSold = false, TowerSet[] filterInTowerSets = null, bool dontDestroyTowersWhenAreaChanges = false) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

