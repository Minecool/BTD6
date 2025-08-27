namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class SharedTowerGrid : SimulationBehavior
{
	internal sealed class GridChanged : MulticastDelegate
	{

		public GridChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private Dictionary<PathSegment, List`1<SharedPathSegmentsInRange>> pathSegmentCounts; //Field offset: 0x58
	[CompilerGenerated]
	private GridChanged OnGridChanged; //Field offset: 0x60

	public event GridChanged OnGridChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public SharedTowerGrid() { }

	[CompilerGenerated]
	public void add_OnGridChanged(GridChanged value) { }

	public Dictionary<PathSegment, List`1<SharedPathSegmentsInRange>> GetSharedTowerPathSegments() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	[CompilerGenerated]
	public void remove_OnGridChanged(GridChanged value) { }

	public void TowerPathSegmentsChanged(List<PathSegmentInRange> oldPathSegments, List<PathSegmentInRange> newPathSegments, Vector3 position, float range, string baseId) { }

	public void TowerPathSegmentsRemoved(List<PathSegmentInRange> oldPathSegments) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

