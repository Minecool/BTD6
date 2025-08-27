namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "TrackTargetSharedRange", menuName = "BTD6/Behaviors/Projectiles/TrackTargetSharedRange")]
public class TrackTargetSharedRange : ProjectileBehavior
{
	public bool sharedRangeEnabled; //Field offset: 0x30
	public float turnRate; //Field offset: 0x34
	public float reaquireTargetDelay; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 151
	}

	public TrackTargetSharedRange() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

