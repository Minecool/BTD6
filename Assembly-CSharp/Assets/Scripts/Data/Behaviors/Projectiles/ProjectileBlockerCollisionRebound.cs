namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ProjectileBlockerCollisionRebound", menuName = "BTD6/Behaviors/Projectiles/ProjectileBlockerCollisionRebound")]
public class ProjectileBlockerCollisionRebound : ProjectileBehavior
{
	public bool clearCollidedWith; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 115
	}

	public ProjectileBlockerCollisionRebound() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

