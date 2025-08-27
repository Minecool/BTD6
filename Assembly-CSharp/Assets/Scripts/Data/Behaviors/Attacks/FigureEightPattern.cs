namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "FigureEightPattern", menuName = "BTD6/Behaviors/Attacks/FigureEightPattern")]
public class FigureEightPattern : TargetTypeBehavior
{
	public float radius; //Field offset: 0x38
	public bool rotated; //Field offset: 0x3C
	public PrefabReference display; //Field offset: 0x40
	public int displayCount; //Field offset: 0x48
	public bool dontUseTowerPosition; //Field offset: 0x4C

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 207
	}

	public FigureEightPattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

