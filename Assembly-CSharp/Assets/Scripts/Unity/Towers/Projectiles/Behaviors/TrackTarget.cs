namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TrackTarget : ProjectileBehavior
{
	public TrackTarget parent; //Field offset: 0x88
	public float distance; //Field offset: 0x90
	public string expDistance; //Field offset: 0x98
	public bool trackNewTargets; //Field offset: 0xA0
	public string expTrackNewTargets; //Field offset: 0xA8
	public bool constantlyAquireNewTarget; //Field offset: 0xB0
	public string expConstantlyAquireNewTarget; //Field offset: 0xB8
	public float maxSeekAngle; //Field offset: 0xC0
	public string expMaxSeekAngle; //Field offset: 0xC8
	public bool ignoreSeekAngle; //Field offset: 0xD0
	public string expIgnoreSeekAngle; //Field offset: 0xD8
	public float turnRate; //Field offset: 0xE0
	public string expTurnRate; //Field offset: 0xE8
	public bool overrideRotation; //Field offset: 0xF0
	public string expOverrideRotation; //Field offset: 0xF8
	public bool useLifetimeAsDistance; //Field offset: 0x100
	public string expUseLifetimeAsDistance; //Field offset: 0x108

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 268
	}

	public TrackTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

