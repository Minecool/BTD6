namespace NinjaKiwi.CustomAnimation;

public class CurvedPath : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <GetCubicBeziers>d__3 : IEnumerable<CubicBezier>, IEnumerable, IEnumerator<CubicBezier>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private CubicBezier <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x44
		public CurvedPath <>4__this; //Field offset: 0x48
		private int <i>5__2; //Field offset: 0x50
		private Curve <curve>5__3; //Field offset: 0x54

		private override CubicBezier System.Collections.Generic.IEnumerator<NinjaKiwi.CustomAnimation.CubicBezier>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 27
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 87
		}

		[DebuggerHidden]
		public <GetCubicBeziers>d__3(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<CubicBezier> System.Collections.Generic.IEnumerable<NinjaKiwi.CustomAnimation.CubicBezier>.GetEnumerator() { }

		[DebuggerHidden]
		private override CubicBezier System.Collections.Generic.IEnumerator<NinjaKiwi.CustomAnimation.CubicBezier>.get_Current() { }

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
	private sealed class <GetSamples>d__6 : IEnumerable<PathSample>, IEnumerable, IEnumerator<PathSample>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PathSample <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CurvedPath <>4__this; //Field offset: 0x28
		private int countPerSegment; //Field offset: 0x30
		public int <>3__countPerSegment; //Field offset: 0x34
		private IEnumerator<CubicBezier> <>7__wrap1; //Field offset: 0x38
		private IEnumerator<CurveSample> <>7__wrap2; //Field offset: 0x40

		private override PathSample System.Collections.Generic.IEnumerator<NinjaKiwi.CustomAnimation.PathSample>.Current
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
		public <GetSamples>d__6(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<PathSample> System.Collections.Generic.IEnumerable<NinjaKiwi.CustomAnimation.PathSample>.GetEnumerator() { }

		[DebuggerHidden]
		private override PathSample System.Collections.Generic.IEnumerator<NinjaKiwi.CustomAnimation.PathSample>.get_Current() { }

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
	private sealed class <GetTileSamples>d__7 : IEnumerable<PathSample>, IEnumerable, IEnumerator<PathSample>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PathSample <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CurvedPath <>4__this; //Field offset: 0x28
		private Vector3 worldSize; //Field offset: 0x30
		public Vector3 <>3__worldSize; //Field offset: 0x3C
		private Size worldTileSize; //Field offset: 0x48
		public Size <>3__worldTileSize; //Field offset: 0x50
		private IEnumerator<CubicBezier> <>7__wrap1; //Field offset: 0x58
		private IEnumerator<CurveSample> <>7__wrap2; //Field offset: 0x60
		private IntPoint <point>5__4; //Field offset: 0x68

		private override PathSample System.Collections.Generic.IEnumerator<NinjaKiwi.CustomAnimation.PathSample>.Current
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
		public <GetTileSamples>d__7(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<PathSample> System.Collections.Generic.IEnumerable<NinjaKiwi.CustomAnimation.PathSample>.GetEnumerator() { }

		[DebuggerHidden]
		private override PathSample System.Collections.Generic.IEnumerator<NinjaKiwi.CustomAnimation.PathSample>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public List<Curve> curves; //Field offset: 0x20
	public Vector3 startPoint; //Field offset: 0x28
	public Vector3 startTangent; //Field offset: 0x34

	public CurvedPath() { }

	[IteratorStateMachine(typeof(<GetCubicBeziers>d__3))]
	public IEnumerable<CubicBezier> GetCubicBeziers() { }

	public void GetSamples(int countPerSegment, List<PathSample> outputList) { }

	[IteratorStateMachine(typeof(<GetSamples>d__6))]
	public IEnumerable<PathSample> GetSamples(int countPerSegment) { }

	[IteratorStateMachine(typeof(<GetTileSamples>d__7))]
	public IEnumerable<PathSample> GetTileSamples(Vector3 worldSize, Size worldTileSize) { }

	private bool PointsAreEqual(Vector3 p1, Vector3 p2, float threshold = 0.0001) { }

}

