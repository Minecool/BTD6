namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "FighterPilotPatternFirst", menuName = "BTD6/Behaviors/Attacks/FighterPilotPatternFirst")]
public class FighterPilotPatternFirst : TargetTypeBehavior
{
	public float offsetDistance; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public FighterPilotPatternFirst() { }

	public virtual AttackBehaviorModel get_Def() { }

}

