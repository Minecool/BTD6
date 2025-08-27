namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SlowBloonsZone : TowerBehavior
{
	public SlowBloonsZone parent; //Field offset: 0x98
	public float zoneRadius; //Field offset: 0xA0
	public string expZoneRadius; //Field offset: 0xA8
	public string mutationId; //Field offset: 0xB0
	public string expMutationId; //Field offset: 0xB8
	public bool isUnique; //Field offset: 0xC0
	public string expIsUnique; //Field offset: 0xC8
	public float speedScale; //Field offset: 0xD0
	public string expSpeedScale; //Field offset: 0xD8
	public float speedChange; //Field offset: 0xE0
	public string expSpeedChange; //Field offset: 0xE8
	public bool bindRadiusToTowerRange; //Field offset: 0xF0
	public string expBindRadiusToTowerRange; //Field offset: 0xF8
	public float radiusOffset; //Field offset: 0x100
	public string expRadiusOffset; //Field offset: 0x108
	public string bloonTag; //Field offset: 0x110
	public string expBloonTag; //Field offset: 0x118
	public bool inclusive; //Field offset: 0x120
	public string expInclusive; //Field offset: 0x128

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 371
	}

	public SlowBloonsZone() { }

	public FilterModel[] GatherFilters() { }

	public virtual TowerBehaviorModel get_Def() { }

}

