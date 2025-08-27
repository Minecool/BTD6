namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetPointer : TargetTypeBehavior
{
	public TargetPointer parent; //Field offset: 0x98
	public string customName; //Field offset: 0xA0
	public string expCustomName; //Field offset: 0xA8
	public bool setOnAttached; //Field offset: 0xB0
	public string expSetOnAttached; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 174
	}

	public TargetPointer() { }

	public virtual AttackBehaviorModel get_Def() { }

}

