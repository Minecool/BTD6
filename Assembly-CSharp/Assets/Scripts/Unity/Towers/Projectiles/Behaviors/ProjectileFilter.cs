namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ProjectileFilter : ProjectileBehavior
{
	public ProjectileFilter parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public ProjectileFilter() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

