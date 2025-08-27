namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetFriendly : TargetSupplier
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__4 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public TargetFriendly <>4__this; //Field offset: 0x68
		private String[] <ignoreList>5__2; //Field offset: 0x70
		private IEnumerator<Tower> <>7__wrap2; //Field offset: 0x78

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
		public <GetTargets>d__4(int <>1__state) { }

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

	public TargetFriendlyModel friendlyTargetModel; //Field offset: 0x68

	public TargetFriendly() { }

	public virtual string GetName() { }

	[IteratorStateMachine(typeof(<GetTargets>d__4))]
	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private int MutatedOrder(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

