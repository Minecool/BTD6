namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class PathSupplierHeli : PathSupplier
{
	[CompilerGenerated]
	private sealed class <GetTargetsInStadium>d__3 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public PathSupplierHeli <>4__this; //Field offset: 0x68
		private Vector2 circleBCenter; //Field offset: 0x70
		public Vector2 <>3__circleBCenter; //Field offset: 0x78
		private Vector2 circleACenter; //Field offset: 0x80
		public Vector2 <>3__circleACenter; //Field offset: 0x88
		private float radius; //Field offset: 0x90
		public float <>3__radius; //Field offset: 0x94
		private Vector2 <aToB>5__2; //Field offset: 0x98
		private IEnumerator<Bloon> <>7__wrap2; //Field offset: 0xA0

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
		public <GetTargetsInStadium>d__3(int <>1__state) { }

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
	private sealed class <Targets>d__4 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public PathSupplierHeli <>4__this; //Field offset: 0x68
		private float range; //Field offset: 0x70
		public float <>3__range; //Field offset: 0x74
		private IEnumerator<Bloon> <>7__wrap1; //Field offset: 0x78

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
		public <Targets>d__4(int <>1__state) { }

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

	protected TransformBehavior heliTransformBehavior; //Field offset: 0xA0

	public PathSupplierHeli() { }

	public virtual IEnumerable<Target> GetTargets() { }

	[IteratorStateMachine(typeof(<GetTargetsInStadium>d__3))]
	public IEnumerable<Target> GetTargetsInStadium(Vector2 circleACenter, Vector2 circleBCenter, float radius) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	[IteratorStateMachine(typeof(<Targets>d__4))]
	protected IEnumerable<Target> Targets(float range) { }

}

