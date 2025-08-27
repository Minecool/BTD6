namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateProjectileOnContact", menuName = "BTD6/Behaviors/Projectiles/CreateProjectileOnContact")]
public class CreateProjectileOnContact : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public bool passOnCollidedWith; //Field offset: 0x40
	public bool dontCreateAtBloon; //Field offset: 0x41
	public bool passOnDirectionToContact; //Field offset: 0x42

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 247
	}

	public CreateProjectileOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

