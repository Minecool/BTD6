namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class KineticChargeProjectile : ProjectileBehavior
{
	public KineticChargeProjectile parent; //Field offset: 0x88
	public float deployRadiusMax; //Field offset: 0x90
	public string expDeployRadiusMax; //Field offset: 0x98
	public float deployTime; //Field offset: 0xA0
	public string expDeployTime; //Field offset: 0xA8
	public float duration; //Field offset: 0xB0
	public string expDuration; //Field offset: 0xB8
	public float travelSpeed; //Field offset: 0xC0
	public string expTravelSpeed; //Field offset: 0xC8
	public int maxAdditionalDamageAmount; //Field offset: 0xD0
	public string expMaxAdditionalDamageAmount; //Field offset: 0xD8
	public int damageTakenMaxAmount; //Field offset: 0xE0
	public string expDamageTakenMaxAmount; //Field offset: 0xE8
	public Projectile projectileExplosion; //Field offset: 0xF0
	public Projectile expProjectileExplosion; //Field offset: 0xF8
	public Effect projectileExplosionEffect; //Field offset: 0x100
	public Effect expProjectileExplosionEffect; //Field offset: 0x108
	public int attackState; //Field offset: 0x110
	public string expAttackState; //Field offset: 0x118
	public string overlay; //Field offset: 0x120
	public string expOverlay; //Field offset: 0x128

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 460
	}

	public KineticChargeProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

