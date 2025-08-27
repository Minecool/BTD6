namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ProjectileFilter", menuName = "BTD6/Behaviors/Projectiles/ProjectileFilter")]
public class ProjectileFilter : ProjectileBehavior
{
	public Filter[] filters; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 132
	}

	public ProjectileFilter() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

