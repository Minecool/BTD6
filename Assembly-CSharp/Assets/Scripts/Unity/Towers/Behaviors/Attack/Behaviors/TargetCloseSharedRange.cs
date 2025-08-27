namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetCloseSharedRange : TargetTypeBehavior
{
	public TargetCloseSharedRange parent; //Field offset: 0x98
	public bool isSharedRangeEnabled; //Field offset: 0xA0
	public string expIsSharedRangeEnabled; //Field offset: 0xA8
	public bool isGlobalRange; //Field offset: 0xB0
	public string expIsGlobalRange; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 174
	}

	public TargetCloseSharedRange() { }

	public virtual AttackBehaviorModel get_Def() { }

}

