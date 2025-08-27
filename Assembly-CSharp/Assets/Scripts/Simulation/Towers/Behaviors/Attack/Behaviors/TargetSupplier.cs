namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetSupplier : AttackBehavior
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__3 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60

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
		public <GetTargets>d__3(int <>1__state) { }

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


	protected TargetSupplier DefaultSupplier
	{
		 get { } //Length: 1028
	}

	public TargetSupplier() { }

	public override void ApplyTargetTypeData(Vector2 data) { }

	public override void ApplyTargetTypeData(Vector2[] data) { }

	public static Target BloonToTarget(Bloon bloon) { }

	public override bool CanHaveTarget() { }

	public override void ClearTargetTypeData() { }

	public Target ConvertToTarget(PathSegment segment) { }

	protected TargetSupplier get_DefaultSupplier() { }

	public override string GetName() { }

	public override Target GetTarget() { }

	[IteratorStateMachine(typeof(<GetTargets>d__3))]
	public override IEnumerable<Target> GetTargets() { }

	public override object GetTargetTypeCustomInputData() { }

	public override void OnSwitchedFrom() { }

	public override void OnSwitchedTo() { }

	protected static float OrderByStrong(Target target) { }

	public override bool TargetsTrack() { }

}

