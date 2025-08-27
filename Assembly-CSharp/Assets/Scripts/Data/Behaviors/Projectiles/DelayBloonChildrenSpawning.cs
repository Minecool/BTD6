namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DelayBloonChildrenSpawning", menuName = "BTD6/Behaviors/Projectiles/DelayBloonChildrenSpawning")]
public class DelayBloonChildrenSpawning : ProjectileBehavior
{
	public float delaySpawnDuration; //Field offset: 0x30
	public bool createWindEffectOnChildBloons; //Field offset: 0x34

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public DelayBloonChildrenSpawning() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

