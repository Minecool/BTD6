namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetLastAirUnit : TargetTypeBehavior
{
	public TargetLastAirUnit parent; //Field offset: 0x98

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 142
	}

	public TargetLastAirUnit() { }

	public virtual AttackBehaviorModel get_Def() { }

}

