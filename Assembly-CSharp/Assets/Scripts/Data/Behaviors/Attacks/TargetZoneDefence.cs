namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetZoneDefence", menuName = "BTD6/Behaviors/Attacks/TargetZoneDefence")]
public class TargetZoneDefence : TargetTypeBehavior
{

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public TargetZoneDefence() { }

	public virtual AttackBehaviorModel get_Def() { }

}

