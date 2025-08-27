namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SpawnZombieOnBloonDestroyed : ProjectileBehavior
{
	public int graveyardManaCost; //Field offset: 0x88
	public Projectile zombieProjectile; //Field offset: 0x90

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 162
	}

	public SpawnZombieOnBloonDestroyed() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

