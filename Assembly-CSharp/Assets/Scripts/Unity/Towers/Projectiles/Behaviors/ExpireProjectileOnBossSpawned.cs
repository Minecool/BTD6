namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ExpireProjectileOnBossSpawned : ProjectileBehavior
{
	public ExpireProjectileOnBossSpawned parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public ExpireProjectileOnBossSpawned() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

