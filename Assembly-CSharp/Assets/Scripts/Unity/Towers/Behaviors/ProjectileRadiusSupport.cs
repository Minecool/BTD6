namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ProjectileRadiusSupport : SupportBehavior
{
	public string filterTowers; //Field offset: 0xC8
	public string expFilterTowers; //Field offset: 0xD0
	public bool isUnique; //Field offset: 0xD8
	public string expIsUnique; //Field offset: 0xE0
	public float multiplier; //Field offset: 0xE8
	public string expMultiplier; //Field offset: 0xF0
	public string mutatorId; //Field offset: 0xF8
	public string expMutatorId; //Field offset: 0x100
	public bool isGlobal; //Field offset: 0x108
	public string expIsGlobal; //Field offset: 0x110

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 379
	}

	public ProjectileRadiusSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

