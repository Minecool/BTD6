namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "CloseTargetTrack", menuName = "BTD6/Behaviors/Attacks/CloseTargetTrack")]
public class CloseTargetTrack : TargetTypeBehavior
{
	public float radius; //Field offset: 0x38
	public float maxOffset; //Field offset: 0x3C

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 172
	}

	public CloseTargetTrack() { }

	public virtual AttackBehaviorModel get_Def() { }

}

