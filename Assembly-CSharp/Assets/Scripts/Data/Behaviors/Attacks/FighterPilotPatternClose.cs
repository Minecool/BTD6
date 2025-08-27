namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "FighterPilotPatternClose", menuName = "BTD6/Behaviors/Attacks/FighterPilotPatternClose")]
public class FighterPilotPatternClose : TargetTypeBehavior
{
	public float offsetDistance; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public FighterPilotPatternClose() { }

	public virtual AttackBehaviorModel get_Def() { }

}

