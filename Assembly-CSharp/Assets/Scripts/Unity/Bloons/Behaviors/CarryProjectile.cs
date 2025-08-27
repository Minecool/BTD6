namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class CarryProjectile : BloonBehavior
{
	public Projectile projectile; //Field offset: 0x88
	public Projectile expProjectile; //Field offset: 0x90
	public Emission emission; //Field offset: 0x98
	public Emission expEmission; //Field offset: 0xA0

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 209
	}

	public CarryProjectile() { }

	public virtual BloonBehaviorModel get_Def() { }

}

