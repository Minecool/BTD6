namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetTrack", menuName = "BTD6/Behaviors/Attacks/TargetTrack")]
public class TargetTrack : TargetTypeBehavior
{
	public float maxOffset; //Field offset: 0x38
	public bool onlyTargetPathsWithBloons; //Field offset: 0x3C

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 171
	}

	public TargetTrack() { }

	public virtual AttackBehaviorModel get_Def() { }

}

