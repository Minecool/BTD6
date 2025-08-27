namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetEliteTargetting : TargetTypeBehavior
{
	public TargetEliteTargetting parent; //Field offset: 0x98
	public float percentageThroughMap; //Field offset: 0xA0
	public string expPercentageThroughMap; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 166
	}

	public TargetEliteTargetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

