namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TrackManuallyGivenTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TrackManuallyGivenTargetModel : ProjectileBehaviorModel
{
	public float turnRate; //Field offset: 0x38
	public float turnRatePerFrame; //Field offset: 0x3C
	public float minumumSpeed; //Field offset: 0x40
	public float minumumSpeedFrames; //Field offset: 0x44
	public float maximumSpeed; //Field offset: 0x48
	public float maximumSpeedFrames; //Field offset: 0x4C
	public float accelerationSpeed; //Field offset: 0x50
	public float accelerationSpeedFrames; //Field offset: 0x54
	public float projectileLifeSpan; //Field offset: 0x58
	public int projectileLifeSpanFrames; //Field offset: 0x5C

	public TrackManuallyGivenTargetModel(string name, float turnRate, float minumumSpeed, float maximumSpeed, float accelerationSpeed, float lifeSpan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

