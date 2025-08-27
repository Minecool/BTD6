namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetFriendly : TargetTypeBehavior
{
	public TargetFriendly parent; //Field offset: 0x98
	public string ignoreList; //Field offset: 0xA0
	public string expIgnoreList; //Field offset: 0xA8
	public string mutationId; //Field offset: 0xB0
	public string expMutationId; //Field offset: 0xB8
	public bool mustHaveWeapon; //Field offset: 0xC0
	public string expMustHaveWeapon; //Field offset: 0xC8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 197
	}

	public TargetFriendly() { }

	public virtual AttackBehaviorModel get_Def() { }

}

