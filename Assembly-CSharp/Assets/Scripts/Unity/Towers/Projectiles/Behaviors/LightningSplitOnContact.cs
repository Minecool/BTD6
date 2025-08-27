namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class LightningSplitOnContact : ProjectileBehavior
{
	public LightningSplitOnContact parent; //Field offset: 0x88
	public int targets; //Field offset: 0x90
	public string expTargets; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public Emission emission; //Field offset: 0xB0
	public Emission expEmission; //Field offset: 0xB8
	public float splitRange; //Field offset: 0xC0
	public string expSplitRange; //Field offset: 0xC8
	public float delay; //Field offset: 0xD0
	public string expDelay; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 261
	}

	public LightningSplitOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

