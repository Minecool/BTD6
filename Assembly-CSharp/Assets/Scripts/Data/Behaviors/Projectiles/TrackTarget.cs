namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "TrackTarget", menuName = "BTD6/Behaviors/Projectiles/TrackTarget")]
public class TrackTarget : ProjectileBehavior
{
	public float distance; //Field offset: 0x30
	public bool trackNewTargets; //Field offset: 0x34
	public bool constantlyAquireNewTarget; //Field offset: 0x35
	public float maxSeekAngle; //Field offset: 0x38
	public bool ignoreSeekAngle; //Field offset: 0x3C
	public float turnRate; //Field offset: 0x40
	public bool overrideRotation; //Field offset: 0x44
	public bool useLifetimeAsDistance; //Field offset: 0x45

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 244
	}

	public TrackTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

