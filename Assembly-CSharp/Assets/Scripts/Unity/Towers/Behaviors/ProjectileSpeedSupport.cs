namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ProjectileSpeedSupport : SupportBehavior
{
	public ProjectileSpeedSupport parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public float multiplier; //Field offset: 0xE0
	public string expMultiplier; //Field offset: 0xE8
	public string mutatorId; //Field offset: 0xF0
	public string expMutatorId; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 264
	}

	public ProjectileSpeedSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

