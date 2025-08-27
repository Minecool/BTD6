namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetFirstWithPreference : TargetTypeBehavior
{
	public TargetFirstWithPreference parent; //Field offset: 0x98
	public string priorityBloonTags; //Field offset: 0xA0
	public string expPriorityBloonTags; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 166
	}

	public TargetFirstWithPreference() { }

	public virtual AttackBehaviorModel get_Def() { }

}

