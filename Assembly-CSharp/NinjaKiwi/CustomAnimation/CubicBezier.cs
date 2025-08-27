namespace NinjaKiwi.CustomAnimation;

public struct CubicBezier
{
	[CompilerGenerated]
	private sealed class <GetSamples>d__5 : IEnumerable<CurveSample>, IEnumerable, IEnumerator<CurveSample>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private CurveSample <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x2C
		public CubicBezier <>4__this; //Field offset: 0x30
		public CubicBezier <>3__<>4__this; //Field offset: 0x60
		private int count; //Field offset: 0x90
		public int <>3__count; //Field offset: 0x94
		private float <t>5__2; //Field offset: 0x98

		private override CurveSample System.Collections.Generic.IEnumerator<NinjaKiwi.CustomAnimation.CurveSample>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 21
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 80
		}

		[DebuggerHidden]
		public <GetSamples>d__5(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<CurveSample> System.Collections.Generic.IEnumerable<NinjaKiwi.CustomAnimation.CurveSample>.GetEnumerator() { }

		[DebuggerHidden]
		private override CurveSample System.Collections.Generic.IEnumerator<NinjaKiwi.CustomAnimation.CurveSample>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public Vector3 startPoint; //Field offset: 0x0
	public Vector3 startTangent; //Field offset: 0xC
	public Vector3 endTangent; //Field offset: 0x18
	public Vector3 endPoint; //Field offset: 0x24

	public CubicBezier(Vector3 startPoint, Vector3 startTangent, Vector3 endTangent, Vector3 endPoint) { }

	[IteratorStateMachine(typeof(<GetSamples>d__5))]
	public IEnumerable<CurveSample> GetSamples(int count) { }

	public Vector3 SamplePoint(float t) { }

	public Vector3 SampleTangent(float t) { }

}

