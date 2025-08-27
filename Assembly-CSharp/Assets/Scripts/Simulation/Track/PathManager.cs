namespace Assets.Scripts.Simulation.Track;

public class PathManager : RootBehavior
{
	[CompilerGenerated]
	private sealed class <GetPathSegmentsInRange>d__21 : IEnumerable<PathSegment>, IEnumerable, IEnumerator<PathSegment>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PathSegment <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public PathManager <>4__this; //Field offset: 0x28
		private Vector2 position; //Field offset: 0x30
		public Vector2 <>3__position; //Field offset: 0x38
		private float range; //Field offset: 0x40
		public float <>3__range; //Field offset: 0x44
		private bool onlyTargetsBloons; //Field offset: 0x48
		public bool <>3__onlyTargetsBloons; //Field offset: 0x49
		private bool onlyTargetsMoabs; //Field offset: 0x4A
		public bool <>3__onlyTargetsMoabs; //Field offset: 0x4B
		private bool segmentMustHaveBloons; //Field offset: 0x4C
		public bool <>3__segmentMustHaveBloons; //Field offset: 0x4D
		private Enumerator<Path> <>7__wrap1; //Field offset: 0x50
		private PathSegment[] <>7__wrap2; //Field offset: 0x68
		private int <>7__wrap3; //Field offset: 0x70

		private override PathSegment System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Track.PathSegment>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetPathSegmentsInRange>d__21(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<PathSegment> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Track.PathSegment>.GetEnumerator() { }

		[DebuggerHidden]
		private override PathSegment System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Track.PathSegment>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetValidExitPaths>d__24 : IEnumerable<Path>, IEnumerable, IEnumerator<Path>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Path <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public PathManager <>4__this; //Field offset: 0x28
		private Enumerator<Path> <>7__wrap1; //Field offset: 0x30

		private override Path System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Track.Path>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetValidExitPaths>d__24(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Path> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Track.Path>.GetEnumerator() { }

		[DebuggerHidden]
		private override Path System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Track.Path>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class BloonDegradeDelegate : MulticastDelegate
	{

		public BloonDegradeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string forId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string forId) { }

	}

	public static int NonMoabKey; //Field offset: 0x0
	public static int NonCamoKey; //Field offset: 0x4
	public List<Path> paths; //Field offset: 0x58
	public Dictionary<Int32, BloonTargetProxy> targets; //Field offset: 0x60
	public bool hasBloons; //Field offset: 0x68
	public bool hasOfftrackBloons; //Field offset: 0x69
	public bool hasMoabs; //Field offset: 0x6A
	public bool onlyHasMoabs; //Field offset: 0x6B
	public bool onlyHasCamo; //Field offset: 0x6C
	[CompilerGenerated]
	private BloonDegradeDelegate OnPathModsChanged; //Field offset: 0x70

	public event BloonDegradeDelegate OnPathModsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private static PathManager() { }

	public PathManager() { }

	[CompilerGenerated]
	public void add_OnPathModsChanged(BloonDegradeDelegate value) { }

	private void FindGlobalBest(Path path) { }

	private Bloon FirstBloonOnPath(Path path) { }

	public PathSegment FirstPathSegmentInRangeOrDefault(Vector2 position, float range, bool onlyTargetsBloons = false, bool onlyTargetsMoabs = false, bool segmentMustHaveBloons = false) { }

	public Path GetEntryPathWithBloonsFurtherestAlong() { }

	public Path GetExitPathWithBloonsFurtherestAlong() { }

	public Path GetPath(string pathId) { }

	[IteratorStateMachine(typeof(<GetPathSegmentsInRange>d__21))]
	public IEnumerable<PathSegment> GetPathSegmentsInRange(Vector2 position, float range, bool onlyTargetsBloons = false, bool onlyTargetsMoabs = false, bool segmentMustHaveBloons = false) { }

	[IteratorStateMachine(typeof(<GetValidExitPaths>d__24))]
	public IEnumerable<Path> GetValidExitPaths() { }

	public bool HasPathSegmentInRange(Vector2 position, float range, bool onlyTargetsBloons = false, bool onlyTargetsMoabs = false, bool segmentMustHaveBloons = false) { }

	public void Init(PathModel[] pathModels) { }

	public void ModPathPointInfo(string forID, Nullable<Single> bloonHeightOffset, Nullable<Single> moabHeightOffset, Nullable<Single> bloonScale, Nullable<Single> moabScale, Nullable<Boolean> bloonsInvulnerable, Nullable<Boolean> moabsInvulnerable) { }

	public void Process(int elapsed) { }

	[CompilerGenerated]
	public void remove_OnPathModsChanged(BloonDegradeDelegate value) { }

	public void Reset() { }

	public void UpdateActivePaths() { }

}

