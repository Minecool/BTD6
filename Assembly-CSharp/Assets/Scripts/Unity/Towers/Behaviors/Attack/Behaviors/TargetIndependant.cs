namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetIndependant : TargetTypeBehavior
{
	public TargetIndependant parent; //Field offset: 0x98
	public AttackBehavior targetProvider; //Field offset: 0xA0
	public AttackBehavior expTargetProvider; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 333
	}

	public TargetIndependant() { }

	public virtual AttackBehaviorModel get_Def() { }

}

