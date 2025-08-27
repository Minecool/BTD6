namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class RandomTarget : TargetTypeBehavior
{
	public RandomTarget parent; //Field offset: 0x98
	public bool keepTargetUntilInvalid; //Field offset: 0xA0
	public string expKeepTargetUntilInvalid; //Field offset: 0xA8
	public bool ignoreOtherRandomTargets; //Field offset: 0xB0
	public string expIgnoreOtherRandomTargets; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 174
	}

	public RandomTarget() { }

	public virtual AttackBehaviorModel get_Def() { }

}

