namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TrackTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TrackTargetModel : ProjectileBehaviorModel
{
	public float distance; //Field offset: 0x38
	public bool trackNewTargets; //Field offset: 0x3C
	public bool constantlyAquireNewTarget; //Field offset: 0x3D
	public float maxSeekAngle; //Field offset: 0x40
	public bool ignoreSeekAngle; //Field offset: 0x44
	public bool overrideRotation; //Field offset: 0x45
	public bool useLifetimeAsDistance; //Field offset: 0x46
	[SerializeField]
	private float turnRate; //Field offset: 0x48
	public float turnRatePerFrame; //Field offset: 0x4C

	public float TurnRate
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public TrackTargetModel(string name, float distance, bool trackNewTargets, bool constantlyAquireNewTarget, float maxSeekAngle, bool ignoreSeekAngle, float turnRate, bool overrideRotation, bool useLifetimeAsDistance) { }

	public virtual Model Clone() { }

	public float get_TurnRate() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_TurnRate(float value) { }

}

