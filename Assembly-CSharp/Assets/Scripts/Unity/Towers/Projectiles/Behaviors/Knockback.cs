namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Knockback : ProjectileBehavior
{
	public Knockback parent; //Field offset: 0x88
	public float moabMultiplier; //Field offset: 0x90
	public string expMoabMultiplier; //Field offset: 0x98
	public float heavyMultiplier; //Field offset: 0xA0
	public string expHeavyMultiplier; //Field offset: 0xA8
	public float lightMultiplier; //Field offset: 0xB0
	public string expLightMultiplier; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8
	public string mutationId; //Field offset: 0xD0
	public string expMutationId; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 220
	}

	public Knockback() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

