namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetSupplierSharedRange : TargetSupplier
{
	private bool sharedTowerGridChanged; //Field offset: 0x68
	private bool towerFullSightGridInitialized; //Field offset: 0x69
	protected bool sharedTargettingEnabled; //Field offset: 0x6A
	private List<PathSegmentInRange> towerFullSightPathSegments; //Field offset: 0x70
	private readonly List<PathSegmentInRange> finalPressedSegments; //Field offset: 0x78

	public TargetSupplierSharedRange() { }

	private List<PathSegmentInRange> GenerateSharedCamoGlobalGrid(Dictionary<PathSegment, List`1<PathSegmentInRange>> sharedSegments) { }

	private void GenerateTowerFullSightGrid() { }

	protected IEnumerable<Target> GetTargets(TargetType targetType, bool global = false) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnGridChanged() { }

	private List<PathSegmentInRange> PressTheGridsTogether(Dictionary<PathSegment, List`1<PathSegmentInRange>> sharedSegments) { }

	public virtual void ThrowCacheUpdated() { }

}

