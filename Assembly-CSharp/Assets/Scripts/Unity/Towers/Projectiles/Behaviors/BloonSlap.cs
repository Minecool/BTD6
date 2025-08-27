namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class BloonSlap : ProjectileBehavior
{
	public BloonSlap parent; //Field offset: 0x88
	public int valueForNormalBloons; //Field offset: 0x90
	public string expValueForNormalBloons; //Field offset: 0x98
	public int valueForCeramicBloons; //Field offset: 0xA0
	public string expValueForCeramicBloons; //Field offset: 0xA8
	public int heavyMultiplier; //Field offset: 0xB0
	public string expHeavyMultiplier; //Field offset: 0xB8
	public int lightMultiplier; //Field offset: 0xC0
	public string expLightMultiplier; //Field offset: 0xC8
	public float lifespan; //Field offset: 0xD0
	public string expLifespan; //Field offset: 0xD8
	public string mutationId; //Field offset: 0xE0
	public string expMutationId; //Field offset: 0xE8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 210
	}

	public BloonSlap() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

