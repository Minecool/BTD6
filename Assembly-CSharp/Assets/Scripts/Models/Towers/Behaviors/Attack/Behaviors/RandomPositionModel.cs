namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(RandomPosition), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomPositionModel : TargetSupplierModel
{
	public float minDistance; //Field offset: 0x38
	public float maxDistance; //Field offset: 0x3C
	public float targetRadius; //Field offset: 0x40
	public float targetRadiusSquared; //Field offset: 0x44
	public bool isSelectable; //Field offset: 0x48
	public float pointDistance; //Field offset: 0x4C
	public bool dontUseTowerPosition; //Field offset: 0x50
	public string areaType; //Field offset: 0x58
	public bool useInverted; //Field offset: 0x60
	public bool ignoreTerrain; //Field offset: 0x61
	public float idealDistanceWithinTrack; //Field offset: 0x64
	public string towerSet; //Field offset: 0x68

	public RandomPositionModel(string name, float minDistance, float maxDistance, float targetRadius, bool isSelectable, float pointDistance, bool dontUseTowerPosition, bool isOnSubTower, string areaType, bool useInverted, bool ignoreTerrain, float idealDistanceWithinTrack, string towerSet) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

