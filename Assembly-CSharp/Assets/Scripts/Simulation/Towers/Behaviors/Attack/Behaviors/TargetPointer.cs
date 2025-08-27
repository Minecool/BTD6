namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetPointer : TargetSupplier
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__11 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public TargetPointer <>4__this; //Field offset: 0x68

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
		public <GetTargets>d__11(int <>1__state) { }

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

	public TargetPointerModel targetPointerModel; //Field offset: 0x68
	private RotateToPointer rotateToPointer; //Field offset: 0x70

	private RotateToPointer RotateToPointer
	{
		private get { } //Length: 93
	}

	public TargetPointer() { }

	private RotateToPointer get_RotateToPointer() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	[IteratorStateMachine(typeof(<GetTargets>d__11))]
	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnSwitchedFrom() { }

	public virtual void OnSwitchedTo() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

