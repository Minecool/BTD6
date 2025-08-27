namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateProjectileOnExpire", menuName = "BTD6/Behaviors/Projectiles/CreateProjectileOnExpire")]
public class CreateProjectileOnExpire : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public bool useRotation; //Field offset: 0x40
	public bool useTargetPosition; //Field offset: 0x41

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 224
	}

	public CreateProjectileOnExpire() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

