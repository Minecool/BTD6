namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetZoneDefence : TargetTypeBehavior
{
	public TargetZoneDefence parent; //Field offset: 0x98

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 142
	}

	public TargetZoneDefence() { }

	public virtual AttackBehaviorModel get_Def() { }

}

