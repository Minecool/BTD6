namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "FarTargetTrack", menuName = "BTD6/Behaviors/Attacks/FarTargetTrack")]
public class FarTargetTrack : TargetTypeBehavior
{
	public float radius; //Field offset: 0x38
	public float donutRadius; //Field offset: 0x3C
	public float maxOffset; //Field offset: 0x40

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 194
	}

	public FarTargetTrack() { }

	public virtual AttackBehaviorModel get_Def() { }

}

