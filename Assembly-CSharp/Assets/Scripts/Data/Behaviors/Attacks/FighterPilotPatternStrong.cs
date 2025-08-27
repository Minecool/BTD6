namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "FighterPilotPatternStrong", menuName = "BTD6/Behaviors/Attacks/FighterPilotPatternStrong")]
public class FighterPilotPatternStrong : TargetTypeBehavior
{
	public float offsetDistance; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public FighterPilotPatternStrong() { }

	public virtual AttackBehaviorModel get_Def() { }

}

