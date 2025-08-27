namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "SmartTargetTrack", menuName = "BTD6/Behaviors/Attacks/SmartTargetTrack")]
public class SmartTargetTrack : TargetTypeBehavior
{
	public float radius; //Field offset: 0x38
	public float maxOffset; //Field offset: 0x3C

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 172
	}

	public SmartTargetTrack() { }

	public virtual AttackBehaviorModel get_Def() { }

}

