namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AdoraTrackTarget : ProjectileBehaviorOnEmit
{
	public const int searchDelayFrames = 5; //Field offset: 0x0
	public AdoraTrackTargetModel adoraTrackTargetModel; //Field offset: 0x68
	private float currentVelocity; //Field offset: 0x70
	private float currentDistance; //Field offset: 0x74
	private bool accelerating; //Field offset: 0x78
	private Vector3 movementDirection; //Field offset: 0x7C
	public int lastTargetSearchElapsed; //Field offset: 0x88

	public AdoraTrackTarget() { }

	public virtual void Collide(Bloon bloon) { }

	protected float GetAngleBetween(Vector3 from, Vector3 to) { }

	private void GetNewTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected bool IsBloonValid(Bloon bloon) { }

	public virtual void OnEmit() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateRotation() { }

	private void UpdateVelocity() { }

}

