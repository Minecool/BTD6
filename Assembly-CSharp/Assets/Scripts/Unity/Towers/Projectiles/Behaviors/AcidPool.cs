namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AcidPool : ProjectileBehavior
{
	public AcidPool parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float lifespanIfMisses; //Field offset: 0xA0
	public string expLifespanIfMisses; //Field offset: 0xA8
	public float radiusIfMisses; //Field offset: 0xB0
	public string expRadiusIfMisses; //Field offset: 0xB8
	public float pierceIfMisses; //Field offset: 0xC0
	public string expPierceIfMisses; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 210
	}

	public AcidPool() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

