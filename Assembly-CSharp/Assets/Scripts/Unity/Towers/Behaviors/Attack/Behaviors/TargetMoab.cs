namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetMoab : TargetTypeBehavior
{
	public TargetMoab parent; //Field offset: 0x98
	public bool findStrongest; //Field offset: 0xA0
	public string expFindStrongest; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 165
	}

	public TargetMoab() { }

	public virtual AttackBehaviorModel get_Def() { }

}

