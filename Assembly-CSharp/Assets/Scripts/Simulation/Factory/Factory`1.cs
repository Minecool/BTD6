namespace Assets.Scripts.Simulation.Factory;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class Factory : IFactory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal T <.cctor>b__19_0() { }

	}

	[CompilerGenerated]
	private sealed class <GetAs>d__13 : IEnumerable<TDerived>, IEnumerable, IEnumerator<TDerived>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private TDerived <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public Factory<T> <>4__this; //Field offset: 0x0
		private StructLockListEnumerable<T> <enumerable>5__2; //Field offset: 0x0
		private Enumerator<T> <>7__wrap2; //Field offset: 0x0

		private override TDerived System.Collections.Generic.IEnumerator<TDerived>.Current
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
		public <GetAs>d__13`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<TDerived> System.Collections.Generic.IEnumerable<TDerived>.GetEnumerator() { }

		[DebuggerHidden]
		private override TDerived System.Collections.Generic.IEnumerator<TDerived>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const int defaultCapacity = 16; //Field offset: 0x0
	private static readonly Func<T> CreateT; //Field offset: 0x0
	public LockList<T> up; //Field offset: 0x0
	public ListLite<T> pool; //Field offset: 0x0
	private readonly Simulation sim; //Field offset: 0x0
	private readonly List<List`1<T>> sampleCreatedTo; //Field offset: 0x0
	private int freePtr; //Field offset: 0x0
	private int createdSinceLastFlush; //Field offset: 0x0

	public override int PooledCount
	{
		 get { } //Length: 8
	}

	private static Factory`1() { }

	public Factory`1(Simulation sim) { }

	public override void Clear() { }

	public T Create() { }

	public override RootBehavior CreateBehavior() { }

	public void EndSampleCreated(List<T> sampleTo) { }

	public override void Flush(bool fullFlush) { }

	public override int get_PooledCount() { }

	[IteratorStateMachine(typeof(<GetAs>d__13`1))]
	public override IEnumerable<TDerived> GetAs() { }

	public static bool IsNull(T obj) { }

	public void SampleCreated(List<T> sampleTo) { }

}

