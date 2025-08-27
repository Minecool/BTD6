namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "KineticChargeProjectile", menuName = "BTD6/Behaviors/Projectiles/KineticChargeProjectile")]
public class KineticChargeProjectile : ProjectileBehavior
{
	public float deployRadiusMax; //Field offset: 0x30
	public float deployTime; //Field offset: 0x34
	public float duration; //Field offset: 0x38
	public float travelSpeed; //Field offset: 0x3C
	public int maxAdditionalDamageAmount; //Field offset: 0x40
	public int damageTakenMaxAmount; //Field offset: 0x44
	public Projectile projectileExplosion; //Field offset: 0x48
	public Effect projectileExplosionEffect; //Field offset: 0x50
	public int attackState; //Field offset: 0x58
	public string overlay; //Field offset: 0x60

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 373
	}

	public KineticChargeProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

