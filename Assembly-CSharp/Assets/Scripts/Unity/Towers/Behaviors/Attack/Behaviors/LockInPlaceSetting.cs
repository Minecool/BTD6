namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class LockInPlaceSetting : TargetTypeBehavior
{
	public LockInPlaceSetting parent; //Field offset: 0x98
	public GameObject display; //Field offset: 0xA0
	public GameObject expDisplay; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 213
	}

	public LockInPlaceSetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

