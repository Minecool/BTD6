namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TrackTargetSharedRange : ProjectileBehavior
{
	public TrackTargetSharedRangeModel trackTargetSharedRangeModel; //Field offset: 0x68
	private float turnRatePerFrame; //Field offset: 0x70
	private int lastUpdateTimeStamp; //Field offset: 0x74
	private FilterInvisible camoFilter; //Field offset: 0x78

	public TrackTargetSharedRange() { }

	private void CalculateDirection() { }

	private float GetAngleBetweenDirectionAndTarget(Vector3 targetLocation) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

