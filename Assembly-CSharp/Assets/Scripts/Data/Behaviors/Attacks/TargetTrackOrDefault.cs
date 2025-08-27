namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetTrackOrDefault", menuName = "BTD6/Behaviors/Attacks/TargetTrackOrDefault")]
public class TargetTrackOrDefault : TargetTypeBehavior
{
	public float radius; //Field offset: 0x38
	public bool useTowerRange; //Field offset: 0x3C
	public bool forceTargetTrack; //Field offset: 0x3D
	public bool useClosestTrack; //Field offset: 0x3E
	public float maxTrackOffset; //Field offset: 0x40

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 218
	}

	public TargetTrackOrDefault() { }

	public virtual AttackBehaviorModel get_Def() { }

}

