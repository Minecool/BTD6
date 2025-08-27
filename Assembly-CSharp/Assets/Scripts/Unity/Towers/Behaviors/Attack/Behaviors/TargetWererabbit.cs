namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetWererabbit : TargetTypeBehavior
{
	public TargetWererabbit parent; //Field offset: 0x98
	public float timeUntilIdle; //Field offset: 0xA0
	public string expTimeUntilIdle; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 163
	}

	public TargetWererabbit() { }

	public virtual AttackBehaviorModel get_Def() { }

}

