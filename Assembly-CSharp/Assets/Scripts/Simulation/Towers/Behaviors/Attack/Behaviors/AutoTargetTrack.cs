namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class AutoTargetTrack : TrackTargetSupplier
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__10 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public AutoTargetTrack <>4__this; //Field offset: 0x68

		private override Target System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Target>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 45
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 107
		}

		[DebuggerHidden]
		public <GetTargets>d__10(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Target> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Towers.Target>.GetEnumerator() { }

		[DebuggerHidden]
		private override Target System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Target>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public AutoTargetTrackModel autoTargetTrackModel; //Field offset: 0x78
	public Dictionary<Path, PathSegment> closestSegToSpawn; //Field offset: 0x80
	public List<Path> pathKeys; //Field offset: 0x88
	public int currentPathIndex; //Field offset: 0x90

	public AutoTargetTrack() { }

	public Target ConvertToTargetWithRandomOffset(PathSegment segment) { }

	public bool FilterBloon(Bloon bloon) { }

	private PathSegment FindFutureIntersectingSegmentOfFirstBloon(Path path, Bloon bloon) { }

	private PathSegment FindSegmentWithFirstBloon(Path path, Bloon bloon) { }

	public virtual void GeneratePoints() { }

	public virtual string GetName() { }

	[IteratorStateMachine(typeof(<GetTargets>d__10))]
	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnRoundSet(int roundSpawned) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

