namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetTrackOrDefault : TrackTargetSupplier
{
	[CompilerGenerated]
	private sealed class <GetBloonTargets>d__11 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public TargetTrackOrDefault <>4__this; //Field offset: 0x68
		private IEnumerator<Target> <>7__wrap1; //Field offset: 0x70

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
		public <GetBloonTargets>d__11(int <>1__state) { }

		private void <>m__Finally1() { }

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

	[CompilerGenerated]
	private sealed class <GetTrackTargets>d__12 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public TargetTrackOrDefault <>4__this; //Field offset: 0x68
		private int <i>5__2; //Field offset: 0x70

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
		public <GetTrackTargets>d__12(int <>1__state) { }

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

	public TargetTrackOrDefaultModel targetTrackOrDefaultModel; //Field offset: 0x78
	private int currentPoint; //Field offset: 0x80
	private Vector3 closestPoint; //Field offset: 0x84
	private bool locationFound; //Field offset: 0x90

	public TargetTrackOrDefault() { }

	public virtual bool CanHaveTarget() { }

	public virtual void GeneratePoints() { }

	[IteratorStateMachine(typeof(<GetBloonTargets>d__11))]
	private IEnumerable<Target> GetBloonTargets() { }

	public virtual string GetName() { }

	public virtual IEnumerable<Target> GetTargets() { }

	[IteratorStateMachine(typeof(<GetTrackTargets>d__12))]
	private IEnumerable<Target> GetTrackTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool TargetsTrack() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

