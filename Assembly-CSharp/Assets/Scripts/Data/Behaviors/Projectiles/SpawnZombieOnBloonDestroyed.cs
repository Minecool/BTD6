namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "SpawnZombieOnBloonDestroyed", menuName = "BTD6/Behaviors/Projectiles/SpawnZombieOnBloonDestroyed")]
public class SpawnZombieOnBloonDestroyed : ProjectileBehavior
{
	public int graveyardManaCost; //Field offset: 0x30
	public Projectile zombieProjectile; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 169
	}

	public SpawnZombieOnBloonDestroyed() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

