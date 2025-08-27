namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "NecromancerTargetTrackWithinRange", menuName = "BTD6/Behaviors/Attacks/NecromancerTargetTrackWithinRange")]
public class NecromancerTargetTrackWithinRange : TargetTypeBehavior
{
	public PrefabReference display; //Field offset: 0x38
	public PrefabReference displayInvalid; //Field offset: 0x40

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 157
	}

	public NecromancerTargetTrackWithinRange() { }

	public virtual AttackBehaviorModel get_Def() { }

}

