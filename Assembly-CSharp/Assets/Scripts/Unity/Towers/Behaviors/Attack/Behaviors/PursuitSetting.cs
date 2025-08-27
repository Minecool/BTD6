namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class PursuitSetting : TargetTypeBehavior
{
	public PursuitSetting parent; //Field offset: 0x98
	public float pursuitDistance; //Field offset: 0xA0
	public string expPursuitDistance; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 163
	}

	public PursuitSetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

