namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetGrapplable : TargetTypeBehavior
{
	public TargetGrapplable parent; //Field offset: 0x98
	public int hooks; //Field offset: 0xA0
	public string expHooks; //Field offset: 0xA8
	public int zomgHooksRequired; //Field offset: 0xB0
	public string expZomgHooksRequired; //Field offset: 0xB8
	public int badHooksRequired; //Field offset: 0xC0
	public string expBadHooksRequired; //Field offset: 0xC8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 378
	}

	public TargetGrapplable() { }

	public virtual AttackBehaviorModel get_Def() { }

}

