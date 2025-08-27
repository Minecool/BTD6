namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "OffsetToTrackTarget", menuName = "BTD6/Behaviors/Attacks/OffsetToTrackTarget")]
public class OffsetToTrackTarget : TargetTypeBehavior
{
	public float trackOffset; //Field offset: 0x38
	public Attack attack; //Field offset: 0x40

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 336
	}

	public OffsetToTrackTarget() { }

	public virtual AttackBehaviorModel get_Def() { }

}

