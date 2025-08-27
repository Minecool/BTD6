namespace Assets.Scripts.Simulation.Factory;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class FactoryFactory
{
	[CompilerGenerated]
	private sealed class <GenerateObjectReports>d__25 : IEnumerable<RootObjectReport>, IEnumerable, IEnumerator<RootObjectReport>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private RootObjectReport <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public FactoryFactory <>4__this; //Field offset: 0x30
		private Enumerator<Type, IFactory> <>7__wrap1; //Field offset: 0x38

		private override RootObjectReport System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Factory.FactoryFactory.RootObjectReport>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 69
		}

		[DebuggerHidden]
		public <GenerateObjectReports>d__25(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<RootObjectReport> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Factory.FactoryFactory.RootObjectReport>.GetEnumerator() { }

		[DebuggerHidden]
		private override RootObjectReport System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Factory.FactoryFactory.RootObjectReport>.get_Current() { }

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
	private sealed class <GetUncast>d__17 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public FactoryFactory <>4__this; //Field offset: 0x0
		private StructLockListEnumerable<T> <behaviors>5__2; //Field offset: 0x0
		private Enumerator<T> <>7__wrap2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetUncast>d__17`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

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
	private sealed class <GetUncastCached>d__18 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public FactoryFactory <>4__this; //Field offset: 0x0
		private StructLockListEnumerable<T> <behaviors>5__2; //Field offset: 0x0
		private Enumerator<T> <>7__wrap2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetUncastCached>d__18`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class CreationInfo
	{
		public Type type; //Field offset: 0x10
		public bool boxed; //Field offset: 0x18
		public bool useLocalIds; //Field offset: 0x19
		public Type[] extendedTypes; //Field offset: 0x20

		public CreationInfo() { }

	}

	internal class EnumerableSequence : IEnumerable<T>, IEnumerable, IBlanketAdd
	{
		[Il2CppSetOption(Option::NullChecks (1), False)]
		[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
		private class CachedEnumerableFrame : IEnumerable<T>, IEnumerable
		{
			[Il2CppSetOption(Option::NullChecks (1), False)]
			[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
			private class CachedEnumerable : IEnumerable<T>, IEnumerable
			{
				private List<T> cache; //Field offset: 0x0
				private bool isCached; //Field offset: 0x0
				private readonly IEnumerable<T> source; //Field offset: 0x0

				public CachedEnumerable(IEnumerable<T> source) { }

				public void ClearCache() { }

				public override IEnumerator<T> GetEnumerator() { }

				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			}

			private readonly Simulation sim; //Field offset: 0x0
			private CachedEnumerable<T> cachedEnumerable; //Field offset: 0x0
			private int lastCachedAt; //Field offset: 0x0

			public CachedEnumerableFrame(Simulation sim, IEnumerable<T> enumerable) { }

			public void ClearCache() { }

			public override IEnumerator<T> GetEnumerator() { }

			public void Set(IEnumerable<T> enumerable) { }

			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		}

		private readonly CachedEnumerableFrame<T> cache; //Field offset: 0x0
		private IEnumerable<T> list; //Field offset: 0x0
		private IEnumerable<T> alive; //Field offset: 0x0

		public int Count
		{
			 get { } //Length: 24
		}

		public EnumerableSequence`1(Simulation sim) { }

		public override void Add(object obj) { }

		public void Add(IEnumerable<T> obj) { }

		public override void ClearCache() { }

		public int get_Count() { }

		public override IEnumerator<T> GetEnumerator() { }

		public static bool NotDestroyed(T obj) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	internal interface IBlanketAdd
	{

		public void Add(object obj) { }

		public void ClearCache() { }

	}

	internal struct RootObjectReport
	{
		public Type objectType; //Field offset: 0x0
		public int pooledCount; //Field offset: 0x8
		public int instanceCount; //Field offset: 0xC

		public int LeakedCount
		{
			 get { } //Length: 7
		}

		public int get_LeakedCount() { }

	}

	private readonly Simulation simulation; //Field offset: 0x10
	private readonly Dictionary<Type, IFactory> factories; //Field offset: 0x18
	private readonly Dictionary<Type, List`1<IFactory>> factoryCache; //Field offset: 0x20
	private readonly Dictionary<Type, IBlanketAdd> getCache; //Field offset: 0x28
	private readonly Dictionary<Type, CreationInfo> implemetationLookup; //Field offset: 0x30

	public FactoryFactory(Simulation simulation) { }

	public bool AnyUncast() { }

	public void Clear() { }

	public void ClearCache() { }

	public T Create() { }

	public RootBehavior CreateBehavior(Type type, out bool boxed, out bool usingLocalIds) { }

	public RootBehavior CreateBehavior(Type type, out bool boxed, out bool usingLocalIds) { }

	public RootBehavior CreateBehavior(Type type) { }

	public TBehavior CreateEntityWithBehavior(TBehaviorModel behaviorModel) { }

	public TBehavior CreateEntityWithBehavior() { }

	private Factory<T> CreateFactory() { }

	private IFactory CreateFactoryByType(Type type) { }

	public void EndSampleCreated(List<T> sampleTo) { }

	public void Flush(bool fullFlush) { }

	private List<IFactory> ForEachFactory() { }

	[IteratorStateMachine(typeof(<GenerateObjectReports>d__25))]
	public IEnumerable<RootObjectReport> GenerateObjectReports() { }

	public EnumerableSequence<T> Get() { }

	private Factory<T> GetFactory() { }

	private IFactory GetFactory(Type type) { }

	public LockList<T> GetRaw() { }

	[IteratorStateMachine(typeof(<GetUncast>d__17`1))]
	public IEnumerable<T> GetUncast() { }

	[IteratorStateMachine(typeof(<GetUncastCached>d__18`1))]
	public IEnumerable<T> GetUncastCached() { }

	public T GetWithId(ObjectId id) { }

	private void RegisterFactory(IFactory factory, Type type) { }

	private void RegisterFactory(Factory<T> factory) { }

	public void SampleCreated(List<T> sampleTo) { }

	public void SampleCreatedAll(List<T> sampleTo) { }

}

