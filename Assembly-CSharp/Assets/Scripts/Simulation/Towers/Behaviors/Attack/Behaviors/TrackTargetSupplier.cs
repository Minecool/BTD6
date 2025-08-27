namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TrackTargetSupplier : TargetSupplier
{
	protected readonly IList<PathSegment> targetPathSegments; //Field offset: 0x68
	protected bool generatePoints; //Field offset: 0x70

	public TrackTargetSupplier() { }

	public override void GeneratePoints() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elasped) { }

	public virtual bool TargetsTrack() { }

	public virtual void ThrowCacheUpdated() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

