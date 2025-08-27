namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class EmitOnDamage : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x88
	public Projectile expProjectile; //Field offset: 0x90
	public Emission emission; //Field offset: 0x98
	public Emission expEmission; //Field offset: 0xA0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 181
	}

	public EmitOnDamage() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

