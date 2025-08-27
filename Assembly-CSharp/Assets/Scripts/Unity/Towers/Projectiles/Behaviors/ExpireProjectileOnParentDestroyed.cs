namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ExpireProjectileOnParentDestroyed : ProjectileBehavior
{
	public ExpireProjectileOnParentDestroyed parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public ExpireProjectileOnParentDestroyed() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

