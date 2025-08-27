namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "FighterPilotPatternLast", menuName = "BTD6/Behaviors/Attacks/FighterPilotPatternLast")]
public class FighterPilotPatternLast : TargetTypeBehavior
{
	public float offsetDistance; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public FighterPilotPatternLast() { }

	public virtual AttackBehaviorModel get_Def() { }

}

