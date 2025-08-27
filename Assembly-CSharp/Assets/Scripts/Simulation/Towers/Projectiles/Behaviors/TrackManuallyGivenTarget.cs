namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TrackManuallyGivenTarget : ProjectileBehavior
{
	private TrackManuallyGivenTargetModel trackManuallyGivenTargetModel; //Field offset: 0x68
	private Vector3 targetPostion; //Field offset: 0x70
	private bool hasTarget; //Field offset: 0x7C
	private float currentVelocity; //Field offset: 0x80
	private bool accelerate; //Field offset: 0x84
	private Vector3 movementDirection; //Field offset: 0x88
	private float minimumSpeedFrames; //Field offset: 0x94
	private float maximumSpeedFrames; //Field offset: 0x98
	private float accelerationSpeedFrames; //Field offset: 0x9C
	private float lifspanFrames; //Field offset: 0xA0

	public TrackManuallyGivenTarget() { }

	private void CalculateDirection() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public void SetTarget(Vector3 position) { }

	public void SetTargetSpeed(float speed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateRotation() { }

}

