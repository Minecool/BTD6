namespace Assets.Scripts.Simulation.Objects;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class Entity : RootObject
{
	[CompilerGenerated]
	private sealed class <GetBehaviors>d__26 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public Entity <>4__this; //Field offset: 0x0
		private StructLockListEnumerable<RootBehavior> <_behaviors>5__2; //Field offset: 0x0
		private Enumerator<RootBehavior> <>7__wrap2; //Field offset: 0x0

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
		public <GetBehaviors>d__26`1(int <>1__state) { }

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
	private sealed class <GetBehaviorsInDependants>d__28 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public Entity <>4__this; //Field offset: 0x0
		private BehaviourSearchEnumerable<T> <_enumerator>5__2; //Field offset: 0x0
		private BehaviourSearchEnumerator<T> <>7__wrap2; //Field offset: 0x0
		private StructLockListEnumerable<Entity> <_dependantEntities>5__4; //Field offset: 0x0
		private Enumerator<Entity> <>7__wrap4; //Field offset: 0x0
		private DependantsSearchEnumerable<T> <_behaviors>5__6; //Field offset: 0x0
		private DependantsSearchEnumerator<T> <>7__wrap6; //Field offset: 0x0

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
		public <GetBehaviorsInDependants>d__28`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

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

	internal struct BehaviourSearchEnumerable : IDisposable
	{
		private readonly LockList<RootBehavior> behaviours; //Field offset: 0x0

		public BehaviourSearchEnumerable`1(LockList<RootBehavior> behaviours) { }

		public override void Dispose() { }

		public BehaviourSearchEnumerator<TSearch> GetEnumerator() { }

	}

	internal struct BehaviourSearchEnumerator
	{
		private readonly IList<RootBehavior> behaviours; //Field offset: 0x0
		private readonly int count; //Field offset: 0x0
		private int index; //Field offset: 0x0
		private TSearch found; //Field offset: 0x0

		public TSearch Current
		{
			 get { } //Length: 5
		}

		public BehaviourSearchEnumerator`1(IList<RootBehavior> behaviours, int count) { }

		public TSearch get_Current() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	internal struct DependantsSearchEnumerable : IDisposable
	{
		private readonly LockList<RootBehavior> behaviors; //Field offset: 0x0
		private readonly LockList<Entity> dependants; //Field offset: 0x0
		private readonly int iteratorCount; //Field offset: 0x0

		public DependantsSearchEnumerable`1(LockList<RootBehavior> behaviors, LockList<Entity> dependants) { }

		public override void Dispose() { }

		public DependantsSearchEnumerator<TSearch> GetEnumerator() { }

		public void ManualDispose() { }

	}

	internal struct DependantsSearchEnumerator
	{
		private readonly IList<RootBehavior> behaviors; //Field offset: 0x0
		private readonly int behaviorCount; //Field offset: 0x0
		private readonly IList<Entity> dependants; //Field offset: 0x0
		private readonly int dependantCount; //Field offset: 0x0
		private TSearch found; //Field offset: 0x0
		private int childIndex; //Field offset: 0x0
		private int pass; //Field offset: 0x0
		private int iteratorId; //Field offset: 0x0

		public TSearch Current
		{
			 get { } //Length: 5
		}

		public DependantsSearchEnumerator`1(IList<RootBehavior> behaviors, int behaviorCount, IList<Entity> dependants, int dependantCount) { }

		public TSearch get_Current() { }

		public bool MoveNext() { }

		private bool MoveNextPass1() { }

		private bool MoveNextPass2() { }

		private void SetupChild() { }

	}

	private static class DependantsSearchIteratorStack
	{
		internal struct IteratorPair
		{
			public DependantsSearchEnumerable<TSearch> enumerable; //Field offset: 0x0
			public DependantsSearchEnumerator<TSearch> enumerator; //Field offset: 0x0

		}

		public static readonly List<IteratorPair<TSearch>> iterators; //Field offset: 0x0

		private static DependantsSearchIteratorStack`1() { }

	}

	private readonly LockList<RootBehavior> behaviors; //Field offset: 0x48
	private TransformBehavior transformBehaviorCache; //Field offset: 0x50
	private TransformBehavior transformBehaviorParentCache; //Field offset: 0x58
	private DisplayBehavior displayBehaviorCache; //Field offset: 0x60
	private LockList<RootObject> dependants; //Field offset: 0x68
	private LockList<Entity> dependantEntities; //Field offset: 0x70
	[CompilerGenerated]
	private Entity <Parent>k__BackingField; //Field offset: 0x78

	public Entity Parent
	{
		[CompilerGenerated]
		 get { } //Length: 70
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Entity() { }

	public T AddBehavior() { }

	private void AddBehavior(T behavior) { }

	public RootBehavior AddBehaviorFromModel(Model behaviorDef, bool ignoreBoxed = false) { }

	public RootBehavior AddBehaviorFromModel(Model behaviorDef, bool ignoreBoxed = false) { }

	private RootBehavior AddBehaviorFromModelAndBox(Model behaviorDef, bool ignoreBoxed = false) { }

	private RootBehavior AddBehaviorFromModelAndBox(Model behaviorDef, bool ignoreBoxed = false) { }

	public void AddBehaviorFromModels(IList<Model> behaviorDefs, List<RootBehavior> newBehaviors = null) { }

	public void AddBehaviorsOrUpdateModels(List<RootBehavior> behaviors, Model[] toAdd) { }

	public void AddBehaviorsOrUpdateModels(List<RootBehavior> behaviors, List<Model> behaviorDefs) { }

	public override void AddDependant(RootObject dependant) { }

	public int CountBehaviorsInDependants() { }

	public bool DoesBehaviorMatchModel(RootBehavior behavior, Model model) { }

	[CompilerGenerated]
	public Entity get_Parent() { }

	public T GetBehavior() { }

	public T GetBehaviorInDependants() { }

	public T GetBehaviorInParent() { }

	[IteratorStateMachine(typeof(<GetBehaviors>d__26`1))]
	public IEnumerable<T> GetBehaviors() { }

	public BehaviourSearchEnumerable<TSearch> GetBehaviorsFast() { }

	[IteratorStateMachine(typeof(<GetBehaviorsInDependants>d__28`1))]
	public IEnumerable<T> GetBehaviorsInDependants() { }

	public DependantsSearchEnumerable<TSearch> GetBehaviorsInDependantsFast() { }

	public DisplayBehavior GetDisplayBehavior() { }

	public TransformBehavior GetTransformBehavior() { }

	public TransformBehavior GetTransformBehaviorInParent() { }

	public bool HasBehavior() { }

	protected virtual void OnDestroy() { }

	public void RemoveBehavior(RootBehavior behavior) { }

	public void RemoveBehaviors(List<T> behaviorsToRemove) { }

	public override void RemoveDependant(RootObject dependant) { }

	[CompilerGenerated]
	public void set_Parent(Entity value) { }

}

