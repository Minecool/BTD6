namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ProjectileBlockerCollisionRebound : ProjectileBehavior
{
	public ProjectileFilter parent; //Field offset: 0x88
	public bool clearCollidedWith; //Field offset: 0x90
	public string expClearCollidedWith; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 118
	}

	public ProjectileBlockerCollisionRebound() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

