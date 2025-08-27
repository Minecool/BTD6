namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ProjectileSpeedSupport", menuName = "BTD6/Behaviors/Towers/ProjectileSpeedSupport")]
public class ProjectileSpeedSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float multiplier; //Field offset: 0x4C
	public string mutatorId; //Field offset: 0x50

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 283
	}

	public ProjectileSpeedSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

