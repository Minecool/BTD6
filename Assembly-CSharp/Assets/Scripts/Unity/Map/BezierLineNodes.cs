namespace Assets.Scripts.Unity.Map;

public class BezierLineNodes : PolyLineNodes
{
	[CompilerGenerated]
	private sealed class <GetPoints>d__0 : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Vector3 <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x20
		public BezierLineNodes <>4__this; //Field offset: 0x28
		private IEnumerator<Vector3> <pointsEnum>5__2; //Field offset: 0x30
		private bool <valid>5__3; //Field offset: 0x38
		private Vector3 <d>5__4; //Field offset: 0x3C
		private Vector3[] <>7__wrap4; //Field offset: 0x48
		private int <>7__wrap5; //Field offset: 0x50

		private override Vector3 System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.SMath.Vector3>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 19
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 78
		}

		[DebuggerHidden]
		public <GetPoints>d__0(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Vector3> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.SMath.Vector3>.GetEnumerator() { }

		[DebuggerHidden]
		private override Vector3 System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.SMath.Vector3>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	public BezierLineNodes() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable<Vector3> <>n__0() { }

	public virtual List<PointInfo> GetPointInfo() { }

	[IteratorStateMachine(typeof(<GetPoints>d__0))]
	public virtual IEnumerable<Vector3> GetPoints() { }

}

