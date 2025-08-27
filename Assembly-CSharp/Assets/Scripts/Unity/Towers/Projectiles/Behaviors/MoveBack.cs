namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class MoveBack : ProjectileBehavior
{
	public MoveBack parent; //Field offset: 0x88
	public float multiplier; //Field offset: 0x90
	public string expMultiplier; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8
	public int layers; //Field offset: 0xB0
	public string expLayers; //Field offset: 0xB8
	public string mutationId; //Field offset: 0xC0
	public string expMutationId; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 181
	}

	public MoveBack() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

