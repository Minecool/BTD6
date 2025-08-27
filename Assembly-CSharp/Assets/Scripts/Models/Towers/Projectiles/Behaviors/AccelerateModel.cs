namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Accelerate), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AccelerateModel : ProjectileBehaviorModel
{
	[SerializeField]
	private float acceleration; //Field offset: 0x38
	public float accelerationFrames; //Field offset: 0x3C
	[SerializeField]
	private float maxSpeed; //Field offset: 0x40
	public float maxSpeedFrames; //Field offset: 0x44
	[SerializeField]
	private float turnRateChange; //Field offset: 0x48
	public float turnRateChangeFrames; //Field offset: 0x4C
	[SerializeField]
	private float maxTurnRate; //Field offset: 0x50
	public float maxTurnRateFrames; //Field offset: 0x54
	public bool decelerate; //Field offset: 0x58

	public AccelerateModel(string name, float acceleration, float maxSpeed, float turnRateChange, float maxTurnRate, bool decelerate) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

