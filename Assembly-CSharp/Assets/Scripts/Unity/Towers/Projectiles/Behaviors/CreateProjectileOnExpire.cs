namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateProjectileOnExpire : ProjectileBehavior
{
	public CreateProjectileOnExpire parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Emission emission; //Field offset: 0x98
	public bool useRotation; //Field offset: 0xA0
	public string expUseRotation; //Field offset: 0xA8
	public bool useTargetPosition; //Field offset: 0xB0
	public string expUseTargetPosition; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 228
	}

	public CreateProjectileOnExpire() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

