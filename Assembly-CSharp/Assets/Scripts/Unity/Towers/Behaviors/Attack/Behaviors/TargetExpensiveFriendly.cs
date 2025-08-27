namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetExpensiveFriendly : TargetTypeBehavior
{
	public TargetExpensiveFriendly parent; //Field offset: 0x98
	public string ignoreList; //Field offset: 0xA0
	public string expIgnoreList; //Field offset: 0xA8
	public bool ignorePrevious; //Field offset: 0xB0
	public string expIgnorePrevious; //Field offset: 0xB8
	public string previousId; //Field offset: 0xC0
	public string expPreviousId; //Field offset: 0xC8
	public bool useRange; //Field offset: 0xD0
	public string expUseRange; //Field offset: 0xD8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 206
	}

	public TargetExpensiveFriendly() { }

	public virtual AttackBehaviorModel get_Def() { }

}

