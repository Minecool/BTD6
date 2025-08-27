namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TrackTargetSharedRange), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TrackTargetSharedRangeModel : ProjectileBehaviorModel
{
	public bool sharedRangeEnabled; //Field offset: 0x38
	public float turnRate; //Field offset: 0x3C
	public float reaquireTargetDelay; //Field offset: 0x40

	public TrackTargetSharedRangeModel(string name, bool sharedRangeEnabled, float turnRate, float reaquireTargetDelay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

