namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TrackTargetWithinTime : TrackTarget
{
	public TrackTargetWithinTimeModel trackTargetWithinTimeModel; //Field offset: 0x98

	public TrackTargetWithinTime() { }

	protected virtual void CalculateDirection(int deltaFrames) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

