namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DelayBloonChildrenSpawning : ProjectileBehavior
{
	public DelayBloonChildrenSpawning parent; //Field offset: 0x88
	public float delaySpawnDuration; //Field offset: 0x90
	public string expDelaySpawnDuration; //Field offset: 0x98
	public bool createWindEffectOnChildBloons; //Field offset: 0xA0
	public string expCreateWindEffectOnChildBloons; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public DelayBloonChildrenSpawning() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

