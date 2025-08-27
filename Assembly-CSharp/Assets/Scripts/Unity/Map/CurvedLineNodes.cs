namespace Assets.Scripts.Unity.Map;

public class CurvedLineNodes : PolyLineNodes
{
	[CompilerGenerated]
	private sealed class <GetPoints>d__1 : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Vector3 <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x20
		public CurvedLineNodes <>4__this; //Field offset: 0x28
		private Vector3[] <anchors>5__2; //Field offset: 0x30
		private int <anchorCount>5__3; //Field offset: 0x38
		private List<Single> <dists>5__4; //Field offset: 0x40
		private int <samples>5__5; //Field offset: 0x48
		private Single[] <xs>5__6; //Field offset: 0x50
		private Single[] <zs>5__7; //Field offset: 0x58
		private float <distPerSample>5__8; //Field offset: 0x60
		private int <l>5__9; //Field offset: 0x64
		private int <r>5__10; //Field offset: 0x68
		private int <i>5__11; //Field offset: 0x6C

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
		public <GetPoints>d__1(int <>1__state) { }

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

	public int samplesPer100Units; //Field offset: 0x38

	public CurvedLineNodes() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable<Vector3> <>n__0() { }

	public virtual List<PointInfo> GetPointInfo() { }

	[IteratorStateMachine(typeof(<GetPoints>d__1))]
	public virtual IEnumerable<Vector3> GetPoints() { }

}

