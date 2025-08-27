namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AddBehaviorToBloonInZone : TowerBehavior
{
	public AddBehaviorToBloonInZone parent; //Field offset: 0x98
	public float zoneRadius; //Field offset: 0xA0
	public string expZoneRadius; //Field offset: 0xA8
	public string mutationId; //Field offset: 0xB0
	public string expMutationId; //Field offset: 0xB8
	public bool isUnique; //Field offset: 0xC0
	public string expIsUnique; //Field offset: 0xC8
	public BloonBehavior behavior; //Field offset: 0xD0
	public BloonBehavior expBehavior; //Field offset: 0xD8
	public string overlayType; //Field offset: 0xE0
	public string expOverlayType; //Field offset: 0xE8
	public bool bindRadiusToTowerRange; //Field offset: 0xF0
	public string expBindRadiusToTowerRange; //Field offset: 0xF8
	public float radiusOffset; //Field offset: 0x100
	public string expRadiusOffset; //Field offset: 0x108

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 474
	}

	public AddBehaviorToBloonInZone() { }

	public FilterModel[] GatherFilters() { }

	public virtual TowerBehaviorModel get_Def() { }

}

