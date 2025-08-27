namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetInFrontOfAirUnit : TargetTypeBehavior
{
	public TargetInFrontOfAirUnit parent; //Field offset: 0x98

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 142
	}

	public TargetInFrontOfAirUnit() { }

	public virtual AttackBehaviorModel get_Def() { }

}

