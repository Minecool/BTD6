namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SilasTrackTarget : ProjectileBehaviorOnEmit
{
	public SilasTrackTargetModel silasTrackTargetModel; //Field offset: 0x68
	private float currentVelocity; //Field offset: 0x70
	private bool accelerating; //Field offset: 0x74
	private Vector3 movementDirection; //Field offset: 0x78
	private bool movingToStartingPosition; //Field offset: 0x84
	private bool waitingToAttack; //Field offset: 0x85
	private int endWaitingAt; //Field offset: 0x88
	private bool playedSound; //Field offset: 0x8C
	private Vector2 globalSpawnPosition; //Field offset: 0x90
	private Vector2 targetLastPosition; //Field offset: 0x98

	public SilasTrackTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected bool IsBloonValid(Bloon bloon) { }

	private void MoveToSpawnPosition() { }

	public virtual void OnEmit() { }

	private void PlaySound() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateRotation() { }

	private void UpdateVelocity() { }

	private void WaitToAttackTimer() { }

}

