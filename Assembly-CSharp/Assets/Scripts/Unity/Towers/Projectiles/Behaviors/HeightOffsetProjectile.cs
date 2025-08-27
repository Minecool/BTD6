namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class HeightOffsetProjectile : ProjectileBehavior
{
	public HeightOffsetProjectile parent; //Field offset: 0x88
	public int numSamples; //Field offset: 0x90
	public string expNumSamples; //Field offset: 0x98
	public AnimCurve heightCurve; //Field offset: 0xA0
	public AnimCurve expHeightCurve; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 290
	}

	public HeightOffsetProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

