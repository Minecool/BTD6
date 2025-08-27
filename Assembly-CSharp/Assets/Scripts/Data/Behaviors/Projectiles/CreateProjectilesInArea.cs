namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateProjectilesInArea", menuName = "BTD6/Behaviors/Projectiles/CreateProjectilesInArea")]
public class CreateProjectilesInArea : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public float interval; //Field offset: 0x40
	public float range; //Field offset: 0x44
	public Effect effectAtProjectile; //Field offset: 0x48
	public Effect effectBeforeProjectile; //Field offset: 0x50
	public float delayBeforeEffect; //Field offset: 0x58
	public float initialDelay; //Field offset: 0x5C
	public int maxProjectileCount; //Field offset: 0x60

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 565
	}

	public CreateProjectilesInArea() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

