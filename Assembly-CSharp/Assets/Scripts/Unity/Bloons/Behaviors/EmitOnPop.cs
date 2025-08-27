namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class EmitOnPop : BloonBehavior
{
	public Projectile projectile; //Field offset: 0x88
	public Projectile expProjectile; //Field offset: 0x90
	public Emission emission; //Field offset: 0x98
	public Emission expEmission; //Field offset: 0xA0
	public bool ignoreSameFrameDegrade; //Field offset: 0xA8
	public string expIgnoreSameFrameDegrade; //Field offset: 0xB0

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 244
	}

	public EmitOnPop() { }

	public virtual BloonBehaviorModel get_Def() { }

}

